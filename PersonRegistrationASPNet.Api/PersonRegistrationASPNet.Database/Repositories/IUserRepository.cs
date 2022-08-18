using PersonRegistrationASPNet.Database.Models;

namespace PersonRegistrationASPNet.Database.Repositories
{
    public interface IUserRepository
    {
        User? GetUser(string username);
        void SaveUser(User user);
    }
}
