using FluentValidation;
using PromoCodeAPI.Services.ViewModelsValidators;
using PromoCodeAPI.ViewModels;

namespace PromoCodeAPI.ViewModelsValidators
{
    public class ShoppingCartViewModelValidator : AbstractValidator<ShoppingCartViewModel>
    {
        public ShoppingCartViewModelValidator()
        {
            RuleFor(shoppingCart => shoppingCart.PromoCode)
                .NotNull()
               // .NotEmpty()
                .WithMessage("Promocode was not informed or empty.");

            RuleFor(shoppingCart => shoppingCart.Date)
                .NotNull()
                .WithMessage("Date was not informed.");

            RuleFor(shoppingCart => shoppingCart.TotalPrice)
                .NotNull()
                // .NotEmpty()
                .GreaterThan(0)
                 .WithMessage("TotalPrice must be informed and greater than zero.");

            RuleFor(shoppingCart => shoppingCart.Sessions.Event)
                .NotNull()
                //.SetValidator(new EventViewModelValidator())
                .WithMessage("The event was not reported.");

            RuleFor(shoppingCart => shoppingCart.Sessions.Theatre)
                .NotNull()
                // .SetValidator(new TheatreViewModelValidator())
                .WithMessage("The theatre was not reported");

            RuleForEach(shoppingCart => shoppingCart.Sessions.Tickets)
                .NotNull()
                //.SetValidator(new TicketsViewModelValidator())
                .WithMessage("No tickets have been entered");
        }
    }
}
