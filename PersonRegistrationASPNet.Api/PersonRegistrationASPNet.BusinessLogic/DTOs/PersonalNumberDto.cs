using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class PersonalNumberDto
    {
        [Required]
        [InputLength(11)]
        [OnlyNumbers]
        public string? PersonalNumber { get; set; }
    }
}
