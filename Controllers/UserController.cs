using System.Linq;
using System.Threading.Tasks;
using ProjectIepAuction.Models.Database;
using ProjectIepAuction.Models.View;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ProjectIepAuction.Controllers{

    public class UserController : Controller{

        private ProjectIepAuctionContext context;
        private UserManager<User> userManager;
        private IMapper mapper;
        private SignInManager<User> signInManager;


        public UserController(ProjectIepAuctionContext context, UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {
            this.context = context;
            this.userManager = userManager;
            this.mapper = mapper;
            this.signInManager = signInManager;
        }

        

        public IActionResult Register(){
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register (RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            /*
                S obzirom da koristimo Identity biblioteku, ona vec u sebi ima mehanizam za dodavanje novog korsnika. Postoji klasa UserManager koja to radi,.
            */
            User user = this.mapper.Map<User>(model);
            IdentityResult result = await this.userManager.CreateAsync(user, model.password);
            if(!result.Succeeded)
            {
                foreach(IdentityError error in result.Errors)
                    ModelState.AddModelError("", error.Description);
                
                return View(model);
            }

            result = await this.userManager.AddToRoleAsync(user, Roles.user.Name);
            if(!result.Succeeded)
            {
                foreach(IdentityError error in result.Errors)
                    ModelState.AddModelError("", error.Description);
                
                return View(model);
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");

            
        } 

        public IActionResult isEmailUnique(string email) 
        {
            /*
                Ova meto da se poziva tako sto se salje zahtev serveru tj. GET zahetv. Sto znaci da se parametri prosledjuju korz adresu, tako sto
                se navodi ImePolja jednako VrednostPOlja. Sto znaci da metoda koja vrsi proveru mora da ima parametar koji se zove isto kao i polje
                u Modelu da bi mogo de se izvrsi povezivanje GET parametara sa tim.
            */

            bool exists = this.context.Users.Where(user=>user.Email == email).Any();

            if(exists)
                return Json("Email already taken!");
            else
                return Json(true);

        }

        public IActionResult isUsernameUnique(string username) 
        {
            /*
                Ova meto da se poziva tako sto se salje zahtev serveru tj. GET zahetv. Sto znaci da se parametri prosledjuju korz adresu, tako sto
                se navodi ImePolja jednako VrednostPOlja. Sto znaci da metoda koja vrsi proveru mora da ima parametar koji se zove isto kao i polje
                u Modelu da bi mogo de se izvrsi povezivanje GET parametara sa tim.
            */

            bool exists = this.context.Users.Where(user=>user.UserName == username).Any();

            if(exists)
                return Json("Username already taken!");
            else
                return Json(true);

        }

        public IActionResult LogIn(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn ( LogInModel model ) {
            if ( !ModelState.IsValid ) {
                return View ( model );
            }

            User user = await this.userManager.FindByNameAsync(model.username);

            var checkPassword = await this.signInManager.CheckPasswordSignInAsync(user, model.password, false);

            if(checkPassword.Succeeded && user.state == "Banned"){
                ModelState.AddModelError("", "You are banned !");
                return View(model);
            }


            var result = await this.signInManager.PasswordSignInAsync ( model.username, model.password, false, false );

            if ( !result.Succeeded ) {
                ModelState.AddModelError ( "", "Username or password not valid!" );
                return View ( model );
            }

            if ( model.returnUrl != null ) {
                return Redirect ( model.returnUrl );
            } else {
                return RedirectToAction ( nameof ( HomeController.Index ), "Home" );
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            await this.signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
      
        }

        public async Task<IActionResult> Profile(){
            User loggedInUser = await this.userManager.GetUserAsync(base.User);
            return View(loggedInUser);
        }
        
        public async Task<IActionResult> ChangeProfile(){
            User loggedInUser = await this.userManager.GetUserAsync(base.User);
            ProfileModel model = new ProfileModel()
            {
                firstName = loggedInUser.firstName,
                username = loggedInUser.UserName,
                lastName = loggedInUser.lastName,
                email = loggedInUser.Email 
            };
            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeProfile ( ProfileModel model ) {
            if ( !ModelState.IsValid ) {
                return View ( model );
            }

            User loggedInUser = await this.userManager.GetUserAsync(base.User);
                       
            var result = await this.userManager.CheckPasswordAsync(loggedInUser, model.password);

            if ( result == false ) {
                ModelState.AddModelError ( "", "Password not valid!" );
                return View ( model );
            } 

            if(loggedInUser.Email != model.email){
                var resultMail = await this.userManager.SetEmailAsync(loggedInUser, model.email);

                if( !resultMail.Succeeded ){
                    ModelState.AddModelError ( "", "Mail not valid!" );
                    return View ( model );
                }
            }

            if(loggedInUser.firstName != model.firstName){
                loggedInUser.firstName = model.firstName;
            }

            if(loggedInUser.lastName != model.lastName){
                loggedInUser.lastName = model.lastName;
            }


            await this.userManager.UpdateAsync(loggedInUser);
            await this.signInManager.RefreshSignInAsync(loggedInUser);

            return RedirectToAction("Profile");
            
        }

        public IActionResult NewPassword(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewPassword ( NewPassword model ) {
            if ( !ModelState.IsValid ) {
                return View ( model );
            }

            User loggedInUser = await this.userManager.GetUserAsync(base.User);

            if(loggedInUser == null){
                return RedirectToAction ( nameof ( UserController.Profile ), "Home" );
            }

           var result = await userManager.ChangePasswordAsync(loggedInUser, model.oldPassword, model.newPassword);

            if(!result.Succeeded)
            {
                //foreach(IdentityError error in result.Errors)
                    ModelState.AddModelError("", "Matori unesi sva polja pravilno!"/*error.Description*/);
                
                return View(model);
            }

            await this.userManager.UpdateAsync(loggedInUser);

            await signInManager.RefreshSignInAsync(loggedInUser);

            return View("ChangePasswordConfirmation");
        }

        public IActionResult CreateAuction(){
            DateTime today = new DateTime();
            today = DateTime.Now;

            CreateAuctionModel model = new CreateAuctionModel()
            {
                openDate = today 
            };

            return View(model);
        }

    }
}

