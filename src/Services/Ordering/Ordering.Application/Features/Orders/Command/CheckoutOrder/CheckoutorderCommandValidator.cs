﻿using FluentValidation;

namespace Ordering.Application.Features.Orders.Command.CheckoutOrder
{
    public class CheckoutorderCommandValidator : AbstractValidator<CheckoutOrderCommand>
    {
        public CheckoutorderCommandValidator()
        {
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage("{Username} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{Username} must not exceed 50 characters.");

            RuleFor(p => p.EmailAddress)
                .NotEmpty().WithMessage("{EmailAddress} is required.");

            RuleFor(p => p.TotalPrice)
                .NotEmpty().WithMessage("{TotalPrice} is required.")
                .GreaterThan(0).WithMessage("{TotalPrice} should be greater than zero.");


        }
    }
}
