using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.Database.Models
{
    public class Address

    {
        public Guid Id { get; set; }
        [MaxLength(30)]
        public string? City { get; set; }
        [MaxLength(30)]
        public string? Street { get; set; }
        public int houseNumber { get; set; }
        public int ApartmentNumber { get; set; }
    }
}
