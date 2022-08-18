namespace PersonRegistrationASPNet.Api.Services
{
    public interface IJwtService
    {
        public string GetJwtToken(string username, string role);
    }
}
