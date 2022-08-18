using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.Attributes
{
    public class InputLengthAttribute : ValidationAttribute
    {
        private readonly int _inputLength;
        public InputLengthAttribute(int InputLength)
        {
            _inputLength = InputLength;
        }
        protected override ValidationResult? IsValid(
        object? value, ValidationContext validationContext)
        {
            if (value is string input)
            {
                if (input.Length != _inputLength)
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
            return ValidationResult.Success;
        }
        private string GetErrorMessage()
        {
            return $"Input length must be exactly {_inputLength} symbols !!!";
        }
    }
}
