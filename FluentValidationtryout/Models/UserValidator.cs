using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidationtryout.Models
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(x => x.UserName).NotNull().Length(10, 20);
            RuleFor(x => x.Password).NotNull();
            RuleFor(x => x.ConfirmPassword).NotNull().Equal(x => x.Password);
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.City).NotNull();
            RuleFor(x => x.State).NotNull();
            RuleFor(x => x.Date).NotNull();
        }

    }
}