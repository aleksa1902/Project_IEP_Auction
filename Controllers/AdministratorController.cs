using System.Linq;
using System.Threading.Tasks;
using ProjectIepAuction.Models.Database;
using ProjectIepAuction.Models.View;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectIepAuction.Controllers{
    
    //[Authorize(Roles = "Administator")] ne radi nesto
    public class AdministratorController : Controller{

        private ProjectIepAuctionContext context;
        private UserManager<User> userManager;
        private RoleManager<IdentityRole> roleManager;
        private IMapper mapper;
        private SignInManager<User> signInManager;

        
        public AdministratorController(ProjectIepAuctionContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager, IMapper mapper)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.signInManager = signInManager;
        }

        public async Task<IActionResult> UserListAsync(){
            var users = userManager.Users; // uzme sve usere

            UserListModel model = new UserListModel(); //pravi modela gde se nalazi lista userList

            User loggedInUser = await this.userManager.GetUserAsync(base.User);

            model.loggedInUser = loggedInUser;
            
            model.userList = new List<User>(); //easy

            foreach(var user in users){
                model.userList.Add(user); //dodaje svakog usera u listu
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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


        public IActionResult AuctionList(){
            UserListModel model = new UserListModel(); 
            
            model.auctionList = new List<Auction>();
            foreach(var auction in context.Auctions){
                model.auctionList.Add(auction);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AcceptAuction ( int? id ) {

            User loggedInUser = await this.userManager.GetUserAsync(base.User);
            
            Auction auction = await this.context.Auctions.FirstOrDefaultAsync(s => s.Id == id);
            //User user = await this.userManager.FindByNameAsync(username);


            if(auction != null){
                auction.state = "READY";
            }

            await this.context.SaveChangesAsync();

            //await this.signInManager.RefreshSignInAsync(loggedInUser); 

            return View();
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

    }
}