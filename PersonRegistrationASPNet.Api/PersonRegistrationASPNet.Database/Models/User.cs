using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.Database.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [MaxLength(20)]
        [Required]
        public string? Username { get; set; }
        [Required]
        public byte[]? Password { get; set; }
        [Required]
        public byte[]? PasswordSalt { get; set; }
        [MaxLength(5)]
        [Required]
        public string? Role { get; set; }
        public virtual UserInfo? UserInfo { get; set; }
    }
}
