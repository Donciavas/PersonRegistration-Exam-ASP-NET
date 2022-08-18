using PersonRegistrationASPNet.BusinessLogic.DTOs;
using PersonRegistrationASPNet.Database.DTOs;

namespace PersonRegistrationASPNet.BusinessLogic.Services
{
    public interface IManagementService
    {
        ResponseDto DeleteUser(Guid userId);
        GetUserInfoDto? GetUserInfo(Guid userId);
        ResponseDto SaveUserInfo(SaveUserInfoDto userInfoDto, Guid UserId);
        ResponseDto ChangeUserName(string name, Guid userId);
        ResponseDto ChangeUserLastName(string lastName, Guid userId);
        ResponseDto ChangeUserPersonalNumber(string personalNumber, Guid userId);
        ResponseDto ChangeUserPhoneNumber(string phoneNumber, Guid userId);
        ResponseDto ChangeUserEmail(string email, Guid userId);
        ResponseDto ChangeUserProfileImage(ImageRequestDto profileImage, Guid userId);
        ResponseDto ChangeUserCity(string city, Guid userId);
        ResponseDto ChangeUserStreet(string street, Guid userId);
        ResponseDto ChangeUserHouseNumber(int houseNumber, Guid userId);
        ResponseDto ChangeUserApartmentNumber(int apartmentNumber, Guid userId);
    }
}
