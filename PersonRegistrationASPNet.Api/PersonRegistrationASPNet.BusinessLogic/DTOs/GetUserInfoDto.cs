namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class GetUserInfoDto
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Asmenskodas { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public int? houseNumber { get; set; }
        public int? ApartmentNumber { get; set; }
        public byte[]? ProfileImage { get; set; }
    }
}
