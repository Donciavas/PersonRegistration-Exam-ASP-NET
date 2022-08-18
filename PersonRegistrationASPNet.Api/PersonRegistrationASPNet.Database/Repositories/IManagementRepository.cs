using PersonRegistrationASPNet.Database.DTOs;
using PersonRegistrationASPNet.Database.Models;

namespace PersonRegistrationASPNet.Database.Repositories
{
    public interface IManagementRepository
    {
        Task<ResponseDto> DeleteUser(Guid userId);
        User GetUserInfo(Guid userId);
        ResponseDto SaveUserInfo(UserInfo userInfo, Guid userId);
        ResponseDto ChangeUserName(string name, Guid userId);
        ResponseDto ChangeUserLastName(string lastName, Guid userId);
        ResponseDto ChangeUserPersonalNumber(string personalNumber, Guid userId);
        ResponseDto ChangeUserPhoneNumber(string phoneNumber, Guid userId);
        ResponseDto ChangeUserEmail(string email, Guid userId);
        ResponseDto ChangeUserProfileImage(byte[] profileImage, Guid userId);
        ResponseDto ChangeUserCity(string city, Guid userId);
        ResponseDto ChangeUserStreet(string street, Guid userId);
        ResponseDto ChangeUserHouseNumber(int houseNumber, Guid userId);
        ResponseDto ChangeUserApartmentNumber(int apartmentNumber, Guid userId);
    }
}
