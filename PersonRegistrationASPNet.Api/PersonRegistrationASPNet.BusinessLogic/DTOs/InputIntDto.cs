using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class InputIntDto
    {
        [Required]
        [NotLessThanNumber(1)]
        public int Number { get; set; }
    }
}
