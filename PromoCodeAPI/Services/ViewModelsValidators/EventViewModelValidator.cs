using FluentValidation;
using PromoCodeAPI.ViewModels;

namespace PromoCodeAPI.Services.ViewModelsValidators
{
    public class EventViewModelValidator : AbstractValidator<EventViewModel>
    {
        public EventViewModelValidator()
        {


            RuleFor(events => events.Id)
                    .NotNull()
                    .NotEmpty()
                    .Equal(0)
                    .WithMessage("Id must be informed and cannot be 0.");

            RuleFor(events => events.Name)
                    .NotNull()
                    .NotEmpty()
                    .Length(1, 255)
                    .WithMessage("Name must be entered and contain 1 to 255 characters");
        }
    }
}
