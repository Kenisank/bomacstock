using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomacApp.Core.Models
{
    public class LoginView
    {
        [Required]
        [Display(Name = "Username")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }


        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}