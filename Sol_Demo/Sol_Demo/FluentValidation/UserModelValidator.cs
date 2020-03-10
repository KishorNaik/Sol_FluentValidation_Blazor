using FluentValidation;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.FluentValidation
{
    public class UserModelValidator : AbstractValidator<UserModel>
    {
        public UserModelValidator()
        {
            RuleFor(leUserModel => leUserModel.FirstName)
                        .NotEmpty()
                        .MaximumLength(20);

            RuleFor(leUserModel => leUserModel.LastName)
                        .NotEmpty()
                        .MaximumLength(20);

            RuleFor(leUserModel => leUserModel.UserAddress)
                       .SetValidator(new UserAddressModelValidator());
        }
    }
}