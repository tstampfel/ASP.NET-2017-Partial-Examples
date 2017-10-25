using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentValidation.Models
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotNull().Length(10, 20);
            RuleFor(x => x.Password).NotNull();
            RuleFor(x => x.RepeatEmail).NotNull().Equal(x => x.Password);
            RuleFor(x => x.Email).NotNull().EmailAddress();
        }

    }
}