using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleValidation.Models
{
    public class User
    {   
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string  Email { get; set; }
        [Required]
        [Compare("Email", ErrorMessage = "The email and confirmation do not match.")]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }



    }
}