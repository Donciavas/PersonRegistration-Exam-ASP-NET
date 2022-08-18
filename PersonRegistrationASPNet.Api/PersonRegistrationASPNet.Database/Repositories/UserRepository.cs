using PersonRegistrationASPNet.Database.Models;

namespace PersonRegistrationASPNet.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User? GetUser(string username)
        {
            var user = _context?.Users?.SingleOrDefault(x => x.Username == username);
            if (user is null)
                return default;
            return user;
        }
        public void SaveUser(User user)
        {
            _context.Users?.Add(user);
            _context.SaveChanges();
        }


    }
}
