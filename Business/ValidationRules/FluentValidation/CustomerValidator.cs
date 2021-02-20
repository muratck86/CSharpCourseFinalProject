using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.ContactName).NotEmpty().MinimumLength(2);
            RuleFor(c => c.CompanyName).NotEmpty().MinimumLength(2);
        }
    }
}
