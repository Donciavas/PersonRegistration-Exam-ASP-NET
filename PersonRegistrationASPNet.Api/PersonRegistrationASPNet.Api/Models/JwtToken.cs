namespace PersonRegistrationASPNet.Api.Models
{
    public class JwtToken
    {
        public string? Token { get; set; }
        public Guid UserId { get; set; }
    }
}
