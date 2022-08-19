using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class SaveUserInfoDto 
    {
        [Required]
        [CheckForWhiteSpaces]
        public string? Name { get; set; }
        [Required]
        [CheckForWhiteSpaces]
        public string? LastName { get; set; }
        public PersonalNumberDto? PersonalId { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public EmailDto? Email { get; set; }
        public virtual ImageRequestDto? ImageRequest { get; set; }
        [Required]
        [CheckForWhiteSpaces]
        public string? City { get; set; }
        [Required]
        public string? Street { get; set; }
        public InputIntDto? Hause { get; set; }
        public InputIntDto? Apartment { get; set; }

    }
}
