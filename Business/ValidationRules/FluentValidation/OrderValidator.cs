using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.OrderDate).NotEmpty().WithMessage(Messages.OrderDateRequired);
            RuleFor(o => o.CustomerId).NotEmpty();
        }
    }
}
