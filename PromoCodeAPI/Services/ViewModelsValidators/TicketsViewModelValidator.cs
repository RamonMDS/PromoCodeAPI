using FluentValidation;
using PromoCodeAPI.ViewModels;

namespace PromoCodeAPI.Services.ViewModelsValidators
{
    public class TicketsViewModelValidator : AbstractValidator<TicketsViewModel>
    {
        public TicketsViewModelValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .Equal(0)
                .WithMessage("Id must be informed and cannot be 0.");

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .Length(1,255)
                .WithMessage("Name must be entered and contain 1 to 255 characters.");

            RuleFor(x => x.Price)
                .NotNull()
                .LessThan(0)
                .WithMessage("Price must be informed and cannot be 0.");

        }
       
    }
}
