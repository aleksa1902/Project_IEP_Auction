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
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime createDate{get; set;}

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime openDate{get; set;}

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime closeDate{get; set;}

    }
}