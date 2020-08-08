using System.ComponentModel.DataAnnotations;
using ProjectIepAuction.Controllers;
using Microsoft.AspNetCore.Mvc;
using ProjectIepAuction.Models.Database;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ProjectIepAuction.Models.View
{
    public class IndexModel{

        public List<User> userList;
        public List<Auction> auctionList;
        public User loggedInUser;

    }
}