using Microsoft.EntityFrameworkCore;
using PersonRegistrationASPNet.Database.DTOs;
using PersonRegistrationASPNet.Database.Models;

namespace PersonRegistrationASPNet.Database.Repositories
{
    public class ManagementRepository : IManagementRepository
    {
        private readonly ApplicationDbContext _context;

        public ManagementRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseDto> DeleteUser(Guid userId)
        {
            try
            {
                var userToDelete = GetUserInfo(userId);
                if (userToDelete is null)
                    return new ResponseDto(false, "Bad user Id");
                _context?.Users?.Remove(userToDelete);
                if (userToDelete.UserInfo != null)
                    _context?.UserInfo?.Remove(userToDelete.UserInfo);
                if (userToDelete?.UserInfo?.Address != null)
                    _context?.Address?.Remove(userToDelete.UserInfo.Address);

                await _context!.SaveChangesAsync();
                return new ResponseDto(true, "user was deleted");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }

        }
        public User GetUserInfo(Guid userId)
        {
            try
            {
                var userInfo = _context?.Users?
                .Include(i => i.UserInfo)
                .ThenInclude(i => i!.Address)
                .SingleOrDefault(n => n.Id == userId);
                if (userInfo is null)
                    return default!;
                return userInfo!;
            }
            catch (Exception ex)
            {
                new ResponseDto(false, $"{ex.Message}");
                return default!;
            }

        }
        public ResponseDto SaveUserInfo(UserInfo userInfo, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                if (user.UserInfo is null)
                {
                    user.UserInfo = userInfo;
                    _context?.UserInfo?.Add(userInfo);
                    _context?.Address?.Add(userInfo.Address!);
                }
                else
                {
                    user.UserInfo.Name = userInfo.Name;
                    user.UserInfo.LastName = userInfo.LastName;
                    user.UserInfo.PersonalNumber = userInfo.PersonalNumber;
                    user.UserInfo.PhoneNumber = userInfo.PhoneNumber;
                    user.UserInfo.Email = userInfo.Email;
                    user.UserInfo.ProfileImage = userInfo.ProfileImage;
                    user.UserInfo.Address!.City = userInfo.Address!.City;
                    user.UserInfo.Address!.Street = userInfo.Address!.Street;
                    user.UserInfo.Address!.houseNumber = userInfo.Address!.houseNumber;
                    user.UserInfo.Address!.ApartmentNumber = userInfo.Address!.ApartmentNumber;
                }
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserName(string name, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.Name = name;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserLastName(string lastName, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.LastName = lastName;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserPersonalNumber(string personalNumber, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.PersonalNumber = personalNumber;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserPhoneNumber(string phoneNumber, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.PhoneNumber = phoneNumber;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserEmail(string email, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.Email = email;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserProfileImage(byte[] profileImage, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.ProfileImage = profileImage;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserCity(string city, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.Address!.City = city;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserStreet(string street, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.Address!.Street = street;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserHouseNumber(int houseNumber, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.Address!.houseNumber = houseNumber;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeUserApartmentNumber(int apartmentNumber, Guid userId)
        {
            try
            {
                var user = GetUserInfo(userId);
                if (user is null)
                    return new ResponseDto(false, "Bad user Id");
                user.UserInfo!.Address!.ApartmentNumber = apartmentNumber;
                _context?.SaveChanges();
                return new ResponseDto(true, "user info was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
    }
}
