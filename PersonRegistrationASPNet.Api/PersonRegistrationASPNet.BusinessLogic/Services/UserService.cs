using PersonRegistrationASPNet.Database.DTOs;
using PersonRegistrationASPNet.Database.Models;
using PersonRegistrationASPNet.Database.Repositories;
using System.Security.Cryptography;


namespace PersonRegistrationASPNet.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public ResponseDto Login(string username, string password, out string role)
        {
            var account = _repository?.GetUser(username);
            if (account is null) role = "";
            else role = account.Role!;
            if (account is null)
                return new ResponseDto(false, "Username or Password does not match");
            if (!VerifyPasswordHash(password, account.Password!, account.PasswordSalt!))
                return new ResponseDto(false, "Username or Password does not match");
            return new ResponseDto(true, $"User logged in ");
        }
        public ResponseDto Signup(string? username, string? password)
        {
            var user = _repository.GetUser(username!);
            if (user is not null)
                return new ResponseDto(false, "User already exists");
            user = CreateUser(username!, password!);
            _repository.SaveUser(user);
            return new ResponseDto(true, "User was created ");
        }

        private User CreateUser(string username, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = username,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
                Role = "User"
            };

            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA512();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {

			using var hmac = new HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }

        public Guid GetUserID(string username)
        {
            var user = _repository.GetUser(username);
            return user!.Id;
        }
    }
}
