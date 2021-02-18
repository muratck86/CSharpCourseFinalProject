using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Unit price can't be empty");
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).
                GreaterThanOrEqualTo(10).When(p => p.CategoryId == 2)
                .WithMessage("Product price must be >= 10"); //if category is 2 then unitprice >= 10
            RuleFor(p => p.ProductName).Must(NotStartWithNum).WithMessage(Messages.InvalidProductNameStartsWithNumber);
        }

        //create our own rules, a method checks if the productname NOT starts with number...
        private bool NotStartWithNum(string arg)
        {
            return arg[0] < '0' || arg[0] > '9';
        }


    }
}
