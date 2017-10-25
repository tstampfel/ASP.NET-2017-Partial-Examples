using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FluentValidation.Models
{
    [FluentValidation.Attributes.Validator(typeof(UserValidator))]
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        [Display(Name = "Repeat Email")]
        public string RepeatEmail { get; set; }


    }
}