using System.Collections.Generic;
using FluentValidation.Results;

namespace PromoCodeAPI.Services.ViewModelResult
{
    public class ValidatorResult
    {
        public ValidatorResult(ValidationResult results)
        {
            msg = new List<string>();
            AddMsg(results);
        }
        public List<string> msg { get; set; }

        private void AddMsg(ValidationResult results)
        {
            foreach (var failure in results.Errors)
            {
                msg.Add($"Property : { failure.PropertyName} failed validation. Error was: { failure.ErrorMessage}");
            }
        }
    }
}
