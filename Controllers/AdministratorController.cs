using System.Linq;
using System.Threading.Tasks;
using ProjectIepAuction.Models.Database;
using ProjectIepAuction.Models.View;
using ProjectIepAuction.Quartz;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Quartz;
using System;

namespace ProjectIepAuction.Controllers{
    
    //[Authorize(Roles = "Administator")] ne radi nesto
    public class AdministratorController : Controller{

        private ProjectIepAuctionContext context;
        private UserManager<User> userManager;
        private RoleManager<IdentityRole> roleManager;
        private IMapper mapper;
        private SignInManager<User> signInManager;
        private ISchedulerFactory schedulerFactory;
        private IScheduler scheduler;
        private bool schedulerStarted = false;

        
        public AdministratorController(ProjectIepAuctionContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager, IMapper mapper, ISchedulerFactory schedulerFactory)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.signInManager = signInManager;
            this.schedulerFactory = schedulerFactory;
        }
        [Authorize(Roles="Administrator")]
        public async Task<IActionResult> UserListAsync(int? page){
            var users = userManager.Users; // uzme sve usere

            UserListModel model = new UserListModel(); //pravi modela gde se nalazi lista userList

            User loggedInUser = await this.userManager.GetUserAsync(base.User);

            model.loggedInUser = loggedInUser;

            IList<User> list = await this.userManager.Users.OrderBy(s => s.state).ToListAsync();
            
            model.userList = list.ToPagedList(page ?? 1,10);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles="Administrator")]
        public async Task<IActionResult> Ban ( string username ) {

            User loggedInUser = await this.userManager.GetUserAsync(base.User);
                       
            User user = await this.userManager.FindByNameAsync(username);

            if(user != null){
                user.state = "Banned";

                foreach(var auction in context.Auctions){
                    if(auction.owner == user){
                        auction.state = "DELETED";

                        this.context.Auctions.Update (auction);
                    }
                }
            }

            await this.userManager.UpdateAsync(user);

            await this.context.SaveChangesAsync ( );

            //await this.signInManager.RefreshSignInAsync(loggedInUser);

            return PartialView("UnbanUser", user);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles="Administrator")]
        public async Task<IActionResult> Unban ( string username ) {

            User loggedInUser = await this.userManager.GetUserAsync(base.User);
                       
            User user = await this.userManager.FindByNameAsync(username);

            if(user != null){
                user.state = "Active";
            }

            await this.userManager.UpdateAsync(user);

            //await this.signInManager.RefreshSignInAsync(loggedInUser); 

            return PartialView("BanUser", user);
            
        }

        [Authorize(Roles="Administrator")]
        public async Task<IActionResult> AuctionList(int? page){
            IList<Auction> list = await this.context.Auctions.Include(t => t.owner).Where(t => t.state == "DRAFT").OrderByDescending(t => t.createDate).ToListAsync();
            
            UserListModel model = new UserListModel(){
                auctionList = list.ToPagedList(page ?? 1,10)
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles="Administrator")]
        public async Task<IActionResult> AcceptAuction ( int? id ) {

            User loggedInUser = await this.userManager.GetUserAsync(base.User);
            
            Auction auction = await this.context.Auctions.FirstOrDefaultAsync(s => s.Id == id);
            //User user = await this.userManager.FindByNameAsync(username);


            if(auction != null){
                auction.state = "READY";
            }


            await this.context.SaveChangesAsync();

            await AuctionTaskJob(auction.Id);

            //await this.signInManager.RefreshSignInAsync(loggedInUser); 

            return View();
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles="Administrator")]
        public async Task<IActionResult> DeclineAuction ( int? id ) {

            User loggedInUser = await this.userManager.GetUserAsync(base.User);
            
            Auction auction = await this.context.Auctions.FirstOrDefaultAsync(s => s.Id == id);
            //User user = await this.userManager.FindByNameAsync(username);


            if(auction != null){
                auction.state = "DELETED";
            }

            await this.context.SaveChangesAsync();

            //await this.signInManager.RefreshSignInAsync(loggedInUser); 

            return View();
            
        }

        public async Task<IActionResult> AuctionTaskJob(int? id){
          if(!schedulerStarted){
              schedulerStarted = true;
              this.scheduler = await this.schedulerFactory.GetScheduler();
              await this.scheduler.Start();
          }

          Auction a = await this.context.Auctions.FirstOrDefaultAsync(s => s.Id == id);

          string aId = id.ToString();
          
          string opDate = a.openDate.Date.ToString();
          
          JobDataMap map = new JobDataMap();
          map.Add("id", aId);
          
          map.Add("date", opDate);
 
          IJobDetail job = JobBuilder.Create<TaskQuartzJob>().SetJobData(map).Build();

          DateTime now = DateTime.Now;
          string todayDate = now.Date.ToString();

          ITrigger trigger;

          if(todayDate == a.openDate.Date.ToString()){
            trigger = TriggerBuilder.Create().StartAt(new DateTimeOffset(DateTime.Now)).Build();
          }else{
            trigger = TriggerBuilder.Create().StartAt(new DateTimeOffset(a.openDate)).Build();
          }  
 
           await this.scheduler.ScheduleJob(job, trigger);
           
           return RedirectToAction(nameof(HomeController.Index), "Home");
    
      }

    }
}