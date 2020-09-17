using System.Linq;
using System.Threading.Tasks;
using ProjectIepAuction.Models.Database;
using ProjectIepAuction.Models.View;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using ProjectIepAuction.Controllers;
using Microsoft.AspNetCore.Authorization;

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

            return Redirect ("/Home/Index");

            
        } 

        public IActionResult isEmailUnique(string email) {
            bool exists = this.context.Users.Where(user=>user.Email == email).Any();

            if(exists)
                return Json("Email already taken!");
            else
                return Json(true);

        }

        public IActionResult isUsernameUnique(string username) 
        {

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
                return Redirect ("/Home/Index");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            await this.signInManager.SignOutAsync();
            return Redirect ("/Home/Index");
      
        }

        [Authorize]
        public async Task<IActionResult> Profile(){
            User loggedInUser = await this.userManager.GetUserAsync(base.User);
            return View(loggedInUser);
        }

        [Authorize]
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

            if(loggedInUser.UserName != model.username){
                loggedInUser.UserName = model.username;
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

        [Authorize]
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
                    ModelState.AddModelError("", "Something is wrong");
                
                return View(model);
            }
            if(model.oldPassword == model.newPassword){
                ModelState.AddModelError("", "Old and new passwords must not be the same");
                
                return View(model);
            }

            await this.userManager.UpdateAsync(loggedInUser);

            await signInManager.RefreshSignInAsync(loggedInUser);

            return View("ChangePasswordConfirmation");
        }
        
        [Authorize]
        public IActionResult CreateAuction(){

            CreateAuctionModel model = new CreateAuctionModel()
            {
                openDate = DateTime.UtcNow
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAuction ( CreateAuctionModel model ) {
            if ( !ModelState.IsValid ) {
                return View ( model );
            }

            User loggedInUser = await this.userManager.GetUserAsync(base.User);

            if(model.openHour > 0){
                model.openDate = model.openDate.AddHours(Convert.ToDouble(model.openHour));
            }

            if(model.openMinute > 0){
                model.openDate = model.openDate.AddMinutes(Convert.ToDouble(model.openMinute));
            }

            if(model.closeHour > 0){
                model.closeDate = model.closeDate.AddHours(model.closeHour);
            }

            if(model.closeMinute > 0){
                model.closeDate = model.closeDate.AddMinutes(model.closeMinute);
            }

            if(model.openDate < DateTime.Now){
                ModelState.AddModelError ( "", "Open date not valid!" );
                    return View ( model );
            }

            if(model.openDate >= model.closeDate){
                ModelState.AddModelError ( "", "Open date and Close date not valid!" );
                    return View ( model );
            }
            
            if(!Microsoft.VisualBasic.Information.IsNumeric(model.startPrice)){
                ModelState.AddModelError ( "", "Start price not valid!" );
                    return View ( model );
            }

            await Console.Out.WriteLineAsync(model.openDate + "===" + model.closeDate);
            await Console.Out.WriteLineAsync(model.openDate + "===" + model.closeDate);
            await Console.Out.WriteLineAsync(model.openDate + "===" + model.closeDate);

            using ( BinaryReader reader = new BinaryReader ( model.image.OpenReadStream ( ) ) ) {
                Auction auction = new Auction ( ) {
                    name = model.name,
                    description = model.description,
                    startPrice = Convert.ToInt32(model.startPrice),
                    currentPrice = Convert.ToInt32(model.startPrice),
                    createDate = DateTime.Now,
                    openDate = model.openDate,
                    closeDate = model.closeDate,
                    state = "DRAFT",
                    owner = loggedInUser,
                    winner = null,
                    image = reader.ReadBytes ( Convert.ToInt32 ( reader.BaseStream.Length ) )
                };
            
            await this.context.Auctions.AddAsync ( auction);

            await this.context.SaveChangesAsync ( );

            return RedirectToAction ( nameof ( HomeController.Index ), "Home" );
            }
        
        }
        
        [Authorize]
        public async Task<IActionResult> AuctionWinnerList(){       
            User loggedInUser = await this.userManager.GetUserAsync(base.User);

            AuctionWinnerList model = new AuctionWinnerList();
            model.auctionList = new List<Auction>();

            foreach(var auction in context.Auctions){
                if(auction.winner != null){
                    User user = auction.winner;
                    if(user.Id == loggedInUser.Id && auction.state == "SOLD") model.auctionList.Add(auction);
                } 
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> EditAuctionList(int? page){
            User loggedInUser = await this.userManager.GetUserAsync(base.User);
            
            UserListModel model = new UserListModel();

            IList<Auction> list = await this.context.Auctions.Include(t => t.owner).Where(t => t.owner == loggedInUser).OrderByDescending(t => t.createDate).ToListAsync();

            model.auctionList = list.ToPagedList(page ?? 1,10);

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> EditAuction(int id){
            User loggedInUser = await this.userManager.GetUserAsync(base.User);

            Auction auction = this.context.Auctions.FirstOrDefault(s => s.Id == id);

            int openH = auction.openDate.Hour;
            int openM = auction.openDate.Minute;

            int closeH = auction.closeDate.Hour;
            int closeM = auction.closeDate.Minute;

            if(auction != null && auction.owner == loggedInUser){
                EditAuctionModel model = new EditAuctionModel()
                {
                    name = auction.name,
                    description = auction.description,
                    startPrice = Convert.ToString(auction.startPrice),
                    openDate = auction.openDate,
                    closeDate = auction.closeDate,
                    auctionId = auction.Id,
                    openHour = openH,
                    openMinute = openM,
                    closeHour = closeH,
                    closeMinute = closeM
                };

                
                

                return View(model);
            }

            return View();
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAuction ( EditAuctionModel model ) {

            //User loggedInUser = await this.userManager.GetUserAsync(base.User);

            Auction auction = this.context.Auctions.FirstOrDefault(s => s.Id == model.auctionId);

            if(auction.name != model.name){
                auction.name = model.name;
            }

            if(auction.description != model.description){
                auction.description = model.description;
            }

            if(auction.startPrice != Convert.ToInt32(model.startPrice)){
                if(!Microsoft.VisualBasic.Information.IsNumeric(model.startPrice)){
                    ModelState.AddModelError ( "", "Start price not valid!" );
                    return View ( model );
                }
                auction.startPrice = Convert.ToInt32(model.startPrice);
                auction.currentPrice = Convert.ToInt32(model.startPrice);
            }
            
            if(model.openHour > 0){
                model.openDate = model.openDate.AddHours(Convert.ToDouble(model.openHour));
            }

            if(model.openMinute > 0){
                model.openDate = model.openDate.AddMinutes(Convert.ToDouble(model.openMinute));
            }

            if(model.closeHour > 0){
                model.closeDate = model.closeDate.AddHours(model.closeHour);
            }

            if(model.closeMinute > 0){
                model.closeDate = model.closeDate.AddMinutes(model.closeMinute);
            }

            if(model.openDate < DateTime.Now){
                ModelState.AddModelError ( "", "Open date not valid!" );
            }

            if(model.openDate >= model.closeDate){
                ModelState.AddModelError ( "", "Open date and close date not valid!" );
            }

            auction.openDate = model.openDate;
            auction.closeDate = model.closeDate;


            if(model.image != null){
            using ( BinaryReader reader = new BinaryReader ( model.image.OpenReadStream ( ) ) ) {
                auction.image = reader.ReadBytes ( Convert.ToInt32 ( reader.BaseStream.Length ) );
            };
            }

            await this.context.SaveChangesAsync ( );

            //await signInManager.RefreshSignInAsync(loggedInUser);

            return RedirectToAction(nameof(UserController.EditAuctionList), "User");
        }
        
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Bid (int? auctionId) {

            await Console.Out.WriteLineAsync("USAO SAM");

            User loggedInUser = await this.userManager.GetUserAsync(base.User);
                       
            Auction auction = this.context.Auctions.Where(a => a.Id == (int)auctionId).FirstOrDefault();

            if(auction.state != "OPEN"){
                return  Json(new { flag = false, alert = "Sorry, the auction is not open!" });
            }

            var owner = this.context.Users.Join(context.Auctions,
                    user => user,
                    win => win.owner,
                    (user, win) => new
                    {
                        UserId = user.Id,
                        auctionId = win.Id
                    }
                ).Where(k => k.auctionId == auction.Id).FirstOrDefault();

            var oldWin = this.context.Users.Join(context.Auctions,
                    user => user,
                    win => win.winner,
                    (user, win) => new
                    {
                        UserId = user.Id,
                        auctionId = win.Id
                    }
                ).Where(k => k.auctionId == auction.Id).FirstOrDefault();

            User oldWinner = null;
            if(oldWin != null){
                oldWinner = this.context.Users.Where(u => u.Id == oldWin.UserId).FirstOrDefault();
            }

            if(loggedInUser.Id != owner.UserId){ 
                await Console.Out.WriteLineAsync("NIJE VLASNIK");               
                if(loggedInUser.tokens > auction.currentPrice){
                    await Console.Out.WriteLineAsync("IMA TOKENA");
                    
                    auction.currentPrice = auction.currentPrice + 1;

                    auction.winner = loggedInUser;

                    TimeSpan timeLeft = auction.closeDate - DateTime.Now;
                    int time = 0;

                    if(timeLeft.TotalSeconds <= 10){
                        auction.closeDate = auction.closeDate.AddSeconds(10);
                        time = 1;
                    }

                    bool saved = false;
                    while (!saved){
                        try{
                            this.context.Update(auction);  
                            this.context.SaveChanges();
                            saved = true;
                        }
                        catch (DbUpdateConcurrencyException e)
                        {
                            return Json(new { flag = false, alert = "Neko je vec bidovao, pokusajte ponovo" });
                        }
                    }
                    await Console.Out.WriteLineAsync("SACUVAO AUKCIJU");

                    Bid bid = new Bid ( ) {
                        price = auction.currentPrice,
                        auctionId = auction.Id,
                        auction = auction,
                        bidDate = DateTime.Now,
                        user = loggedInUser,
                        userId = loggedInUser.Id
                    };

                    await this.context.Bids.AddAsync(bid);
                    await Console.Out.WriteLineAsync("SACUVAO BID");

                    if(oldWinner != null){
                        oldWinner.tokens = oldWinner.tokens + auction.currentPrice - 1;
                        this.context.Users.Update(oldWinner);
                        await Console.Out.WriteLineAsync("SACUVAO OLD");
                    } 

                    loggedInUser.tokens = loggedInUser.tokens - auction.currentPrice;


                    await this.userManager.UpdateAsync(loggedInUser);

                    await this.context.SaveChangesAsync ( );

                    await Console.Out.WriteLineAsync("SACUVAO SVE");

                    if(time == 1){
                        return  Json(new { flag = true, newWinner = loggedInUser.UserName, closeDate = auction.closeDate.ToString("yyyy,MM,d,H,m,s")  });
                    }else{
                        return  Json(new { flag = true, newWinner = loggedInUser.UserName  });
                    }
    
                }else{
                    
                    return  Json(new { flag = false, alert = "You dont have enought tokens on your account!" });
                }
            }else{
                return  Json(new { flag = false, alert = "Vi ste vlasnik !" });
            }

            
            
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CloseBid(int? auctionId)
        {

            Auction auction = await this.context.Auctions.Include(a => a.winner).Where(a => a.Id == (int)auctionId).FirstOrDefaultAsync();

            if(auction != null){
                if(auction.winner != null){
                    auction.state = "SOLD";
                }else{
                    auction.state = "EXPIRED";
                }
            }

            try
            {
                this.context.Update(auction);
                await this.context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e){
                return Json(new { flag = false, alert = "" });

            }

            return Json(new {
                flag = true
            });      
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public string FindUser(int? auctionId, int? ii){

            Auction auction = this.context.Auctions.Where(a => a.Id == (int)auctionId).FirstOrDefault();

            User user = this.context.Users.Where(u => u == auction.winner).FirstOrDefault();

            return user.UserName;

        }

        [HttpPost]
        public async Task<int> Tokens(){
            User loggedInUser = await this.userManager.GetUserAsync(base.User); 

            return loggedInUser.tokens;
        }



    }
}

