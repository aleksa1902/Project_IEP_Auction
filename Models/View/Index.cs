using System.ComponentModel.DataAnnotations;
using ProjectIepAuction.Controllers;
using Microsoft.AspNetCore.Mvc;
using ProjectIepAuction.Models.Database;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace ProjectIepAuction.Models.View
{
    public class IndexModel{

        public List<User> userList;
        public List<Auction> auctionList;
        public IOrderedQueryable<ProjectIepAuction.Models.Database.Bid> bids;
        public User loggedInUser;

        public Auction auction;
        public string userName;
    }
}