using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PersonRegistrationASPNet.BusinessLogic.Attributes
{
    public class EmailValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
           object? value, ValidationContext validationContext)
        {
            var isValid = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (value is string input)
            {
                if (!isValid.IsMatch(input))
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
            return ValidationResult.Success;
        }
        private string GetErrorMessage()
        {
            return $"Email is not in valid format";
        }
    }
}
