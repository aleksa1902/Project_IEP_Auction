using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectIepAuction.Models.Database;
using ProjectIepAuction.Models.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectIepAuction.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        private UserManager<User> userManager;
        private ProjectIepAuctionContext context;
        private SignInManager<User> signInManager;


        public PaymentController(ProjectIepAuctionContext context, UserManager<User> userManager,  SignInManager<User> signInManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


         public async Task<IActionResult> Payment()
         {
             User loggedInUser = await this.userManager.GetUserAsync(base.User);
             int tokens = loggedInUser.tokens;
             return View(tokens);
         }

         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Payment(string bagName)
         {
             User loggedInUser = await this.userManager.GetUserAsync(base.User);
             int idBag = 0;
             int tokenAmount = 0;
             switch(bagName)
             {
                 case "4.99":
                 {
                     idBag=1;
                     tokenAmount = 5;
                 }
                 break;
                 case "9.99":
                {
                     idBag=2;
                     tokenAmount = 10;
                 }
                 break;
                 case "17.99":
                {
                     idBag=3;
                     tokenAmount = 20;
                 }
                 break;
             }

             TokenTransaction transaction = new TokenTransaction()
             {
                 bagId = idBag,
                 userId = loggedInUser.Id,
                 purchaseDate = DateTime.Now,
             };

             await this.context.TokenTransactions.AddAsync(transaction);
             await this.context.SaveChangesAsync();

             loggedInUser.tokens += tokenAmount;
             await this.userManager.UpdateAsync(loggedInUser);

             await signInManager.RefreshSignInAsync(loggedInUser);

             return Json(true);
         }    


    }

}