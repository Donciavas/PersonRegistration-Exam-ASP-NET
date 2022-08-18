using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class UserDto
    {
        [Required]
        [MinInputLength(4)]
        [ChechWhiteSpaces]
        public string? Username { get; set; }
        [Required]
        [MinInputLength(8)]
        [ChechWhiteSpaces]
        public string? Password { get; set; }
    }
}
