using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class StringInputDto
    {
        [Required]
        [MinInputLength(3)]
        [ChechWhiteSpaces]
        public string? UserInput { get; set; }
    }
}
