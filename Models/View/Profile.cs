using System.ComponentModel.DataAnnotations;
using ProjectIepAuction.Controllers;
using Microsoft.AspNetCore.Mvc;
using ProjectIepAuction.Models.Database;
using Microsoft.AspNetCore.Identity;

namespace ProjectIepAuction.Models.View
{
    public class ProfileModel{
        
        [Display(Name = "Username")]
        public string username { get; set; }

        [Display(Name = "First name")]
        public string firstName { get; set; }

        [Display(Name = "Last name")]
        public string lastName { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [HiddenInput]
        public string returnUrl { get; set; }
        

        



    }
}