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

        public async Task<IActionResult> Index()
        {

             IList<Auction> list = await this.context.Auctions.Include(t => t.owner).Where(t => t.state == "OPEN").OrderByDescending(t => t.openDate).ToListAsync();
             
             int auctionsCount = list.Count;
             
             IndexModel model = new IndexModel()
             {
                 currentPage = 1,
                 pageNumbers = (int)Math.Ceiling(auctionsCount/12.0),
                 auctionsList = list.ToPagedList(1,12)
             };

            return View(model);
           
        }

        public async Task<IActionResult> NextPage(int? page)
        {

             IList<Auction> list = await this.context.Auctions.Include(t => t.owner).Where(t => t.state == "OPEN").OrderByDescending(t => t.openDate).ToListAsync();
             
             int auctionsCount = list.Count;
             
             IndexModel auction = new IndexModel()
             {
                 currentPage = (int)page,
                 pageNumbers = (int)Math.Ceiling(auctionsCount/12.0),
                 auctionsList = list.ToPagedList((int)page,12)
             };

            return PartialView ("List", auction);
           
        }

        public async Task<IActionResult> FilteredPage(int? page, String search, int? minimumPrice, int? maximumPrice, String state)
        {

            IQueryable<Auction> FilterListAuction = this.context.Auctions;
            
            if(search!=null) FilterListAuction = FilterListAuction.Where(a => a.name.Contains(search));
            
            if(minimumPrice != null)
                if(minimumPrice >= 0) FilterListAuction = FilterListAuction.Where(a => a.currentPrice >= minimumPrice);
            
            if(maximumPrice != null)
                if(maximumPrice > 0) FilterListAuction = FilterListAuction.Where(a => a.currentPrice <= maximumPrice);
            
            if(state != "OPEN") FilterListAuction = FilterListAuction.Where(a => a.state==state);
            
            IList<Auction> list = await FilterListAuction.OrderByDescending(a => a.createDate).ToListAsync();
             
             int auctionsCount = list.Count;
             
             IndexModel auction = new IndexModel(){
                 currentPage = (int)page,
                 pageNumbers = (int)Math.Ceiling(auctionsCount/12.0),
                 auctionsList = list.ToPagedList((int)page,12)
             };

            return PartialView ("List", auction);
           
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

        public IActionResult  Error(){
            return View();
        }

        
    }
}
