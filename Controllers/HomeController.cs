using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectIepAuction.Models;
using ProjectIepAuction.Models.Database;
using ProjectIepAuction.Models.View;

namespace ProjectIepAuction.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProjectIepAuctionContext context;

        public HomeController(ProjectIepAuctionContext context, ILogger<HomeController> logger)
        {
            this.context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IndexModel model = new IndexModel();
            model.auctionList = new List<Auction>();
            foreach(var auction in context.Auctions){
                if(auction.state == "OPEN")
                    model.auctionList.Add(auction);
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult GetInfoAuction(int id){
            IndexModel model = new IndexModel();

            foreach(var auction in context.Auctions){
                if(auction.Id == id) {
                    model.auction = auction;
                    break;
                }
            }
            
            return View(model);
        }
    }
}
