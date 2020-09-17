using System.ComponentModel.DataAnnotations;
using ProjectIepAuction.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;

namespace ProjectIepAuction.Models.View
{
    public class CreateAuctionModel{
        [Required]
        [Display(Name = "Name")]
        public string name{get; set;}

        [Required]
        [Display(Name = "Description")]
        public string description{get; set;}

        [Required]
        [Display ( Name = "File")]
        public IFormFile image { get; set; }

        [Required]
        [Display(Name = "Start price")]
        public string startPrice{get; set;}

        [Required]
        [DataType(DataType.Date)]

        public DateTime createDate{get; set;}

        [Required]
        [Display ( Name = "Open date")]
        [DataType(DataType.Date)]
 
        public DateTime openDate{get; set;}

        [Required]
        [Display ( Name = "Close date")]
        [DataType(DataType.Date)]

        public DateTime closeDate{get; set;}

        public int openHour{get;set;}

        public int closeHour{get;set;}

        public int openMinute{get;set;}

        public int closeMinute{get;set;}

    }
}