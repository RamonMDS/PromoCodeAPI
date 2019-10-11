using FluentValidation;
using PromoCodeAPI.ViewModels;

namespace PromoCodeAPI.Services.ViewModelsValidators
{
    public class TheatreViewModelValidator : AbstractValidator<TheatreViewModel>
    {
        public TheatreViewModelValidator()
        {            
            RuleFor(theatre => theatre.Id)
                .NotNull()
                .Equal(0)
                .WithMessage("Id must be informed and cannot be 0.");

            RuleFor(theatre => theatre.Name)
                .NotNull()
                .Length(1, 255)
                .WithMessage("Name must be entered and contain 1 to 255 characters.");
        }
    }
}
