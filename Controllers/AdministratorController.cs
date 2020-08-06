using System.Linq;
using System.Threading.Tasks;
using ProjectIepAuction.Models.Database;
using ProjectIepAuction.Models.View;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

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
            }

            await this.userManager.UpdateAsync(user);

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
            var users = userManager.Users;

            UserListModel model = new UserListModel(); 
            
            model.userList = new List<User>();

            foreach(var user in users){
                model.userList.Add(user);
            }

            return View(model);
        }

    }
}