using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectIepAuction.Models;
using ProjectIepAuction.Models.Database;
using ProjectIepAuction.Models.View;
using X.PagedList;

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

        public async Task<IActionResult> Index(int? page)
        {

             IList<Auction> list = await this.context.Auctions.Include(t => t.owner).Where(t => t.state == "OPEN").OrderByDescending(t => t.openDate).ToListAsync();

             IndexModel model = new IndexModel()
             {
                 auctionsList = list.ToPagedList(page ?? 1,12)
             };

            return View(model);
           
        }


        public ViewResult GetInfoAuction(int id){
            IndexModel model = new IndexModel();

            model.auction = this.context.Auctions.Include(a => a.owner)
            .FirstOrDefault(s => s.Id == id);

            return View(model);
        }

        public ViewResult BidList(int id){
            IndexModel model = new IndexModel();

            model.auction = this.context.Auctions.Include(a => a.owner)
            .FirstOrDefault(s => s.Id == id);

            model.bids = this.context.Bids.Where(a => a.auctionId == model.auction.Id).OrderByDescending(b => b.price);

            return View(model);
        }
    }
}
