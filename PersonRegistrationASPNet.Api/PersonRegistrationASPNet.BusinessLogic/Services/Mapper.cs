using PersonRegistrationASPNet.BusinessLogic.DTOs;
using PersonRegistrationASPNet.Database.Models;

namespace PersonRegistrationASPNet.BusinessLogic.Services
{
    public class Mapper : IMapper
    {
        public GetUserInfoDto ReturnUserInfoDtoFromDB(User? user)
        {
            if (user is null)
                return default!;
            var getUserInfoDto = new GetUserInfoDto()
            {
                Name = user?.UserInfo?.Name,
                LastName = user?.UserInfo?.LastName,
                Asmenskodas = user?.UserInfo?.PersonalNumber,
                PhoneNumber = user?.UserInfo?.PhoneNumber,
                Email = user?.UserInfo?.Email,
                ProfileImage = user?.UserInfo?.ProfileImage,
                City = user?.UserInfo?.Address?.City,
                Street = user?.UserInfo?.Address?.Street,
                houseNumber = user?.UserInfo?.Address?.houseNumber,
                ApartmentNumber = user?.UserInfo?.Address?.ApartmentNumber
            };
            return getUserInfoDto;
        }

        public UserInfo CreateUserInfo(SaveUserInfoDto setUserInfoDto)
        {
            var newUserInfo = new UserInfo()
            {
                Name = setUserInfoDto?.Name,
                LastName = setUserInfoDto?.LastName,
                PersonalNumber = setUserInfoDto?.PersonalId?.PersonalNumber,
                PhoneNumber = setUserInfoDto?.PhoneNumber,
                Email = setUserInfoDto?.Email?.Email,
                Address = new Address()
                {
                    City = setUserInfoDto?.City,
                    Street = setUserInfoDto?.Street,
                    houseNumber = setUserInfoDto!.House!.Number,
                    ApartmentNumber = setUserInfoDto.Apartment!.Number
                }
            };
            return newUserInfo;
        }

    }
}

