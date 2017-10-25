using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FluentValidationtryout.Models
{
    [FluentValidation.Attributes.Validator(typeof(UserValidator))]
    public class User
    {
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Phone { get; set; }
        public DateTime Date { get; set; }


    }
}