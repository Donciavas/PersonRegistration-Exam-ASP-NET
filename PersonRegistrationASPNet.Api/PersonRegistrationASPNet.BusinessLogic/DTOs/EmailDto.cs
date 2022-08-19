using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class EmailDto
    {
        [Required]
        [EmailValidation]
        [CheckForWhiteSpaces]
        public string? Email { get; set; }
    }
}
