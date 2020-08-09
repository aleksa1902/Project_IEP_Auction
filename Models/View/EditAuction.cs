using System.ComponentModel.DataAnnotations;
using ProjectIepAuction.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using ProjectIepAuction.Models.Database;

namespace ProjectIepAuction.Models.View
{
    public class EditAuctionModel{
       
        [Display(Name = "Name")]
        public string name{get; set;}

       
        [Display(Name = "Description")]
        public string description{get; set;}
       
        [Display ( Name = "image")]
        public IFormFile image { get; set; }

      
        [Display(Name = "Start price")]
        public string startPrice{get; set;}

      
        [DataType(DataType.Date)]
        public DateTime openDate{get; set;}

        
        [DataType(DataType.Date)]
        public DateTime closeDate{get; set;}

        public int auctionId;

    }
}