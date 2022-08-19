using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class UserDto
    {
        [Required]
        [MinInputLength(4)]
        [CheckForWhiteSpaces]
        public string? Username { get; set; }
        [Required]
        [MinInputLength(8)]
        [CheckForWhiteSpaces]
        public string? Password { get; set; }
    }
}
