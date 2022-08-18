using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class EmailDto
    {
        [Required]
        [EmailValidation]
        [ChechWhiteSpaces]
        public string? Email { get; set; }
    }
}
