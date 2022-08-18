using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.Database.Models
{
    public class UserInfo
    {
        public Guid Id { get; set; }
        [MaxLength(12)]
        public string? Name { get; set; }
        [MaxLength(12)]
        public string? LastName { get; set; }
        [MaxLength(11)]
        public string? PersonalNumber { get; set; }
        [MaxLength(14)]
        public string? PhoneNumber { get; set; }
        [MaxLength(30)]
        public string? Email { get; set; }
        public byte[]? ProfileImage { get; set; }
        public virtual Address? Address { get; set; }
    }
}
