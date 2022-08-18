using PersonRegistrationASPNet.Database.DTOs;

namespace PersonRegistrationASPNet.BusinessLogic.Services
{
    public interface IUserService
    {
        ResponseDto Signup(string username, string password);
        ResponseDto Login(string username, string password, out string role);
        Guid GetUserID(string username);

    }
}
