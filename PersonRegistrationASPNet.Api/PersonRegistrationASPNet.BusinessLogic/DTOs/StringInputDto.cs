using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class StringInputDto
    {
        [Required]
        [MinInputLength(3)]
        [CheckForWhiteSpaces]
        public string? UserInput { get; set; }
    }
}
