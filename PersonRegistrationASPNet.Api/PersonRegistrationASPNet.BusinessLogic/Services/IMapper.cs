using PersonRegistrationASPNet.BusinessLogic.DTOs;
using PersonRegistrationASPNet.Database.Models;

namespace PersonRegistrationASPNet.BusinessLogic.Services
{
    public interface IMapper
    {
        GetUserInfoDto ReturnUserInfoDtoFromDB(User? user);
        UserInfo CreateUserInfo(SaveUserInfoDto setUserInfoDto);
    }
}
