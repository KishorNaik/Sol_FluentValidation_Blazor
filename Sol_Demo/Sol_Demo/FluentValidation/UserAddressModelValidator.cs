using FluentValidation;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.FluentValidation
{
    public class UserAddressModelValidator : AbstractValidator<UserAddressModel>
    {
        public UserAddressModelValidator()
        {
            RuleFor((leUserAddressModel) => leUserAddressModel.City)
                    .NotEmpty();

            RuleFor((leUserAddressModel) => leUserAddressModel.PostalCode)
                    .NotEmpty()
                    .MaximumLength(6);
        }
    }
}