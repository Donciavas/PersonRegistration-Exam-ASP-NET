using PersonRegistrationASPNet.BusinessLogic.DTOs;
using PersonRegistrationASPNet.Database.DTOs;
using PersonRegistrationASPNet.Database.Repositories;

namespace PersonRegistrationASPNet.BusinessLogic.Services
{
    public class ManagementService : IManagementService
    {
        private readonly IManagementRepository _repository;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;

        public ManagementService(IManagementRepository repository, IMapper mapper, IImageService imageService)
        {
            _repository = repository;
            _mapper = mapper;
            _imageService = imageService;
        }

        public ResponseDto DeleteUser(Guid userId)
        {
            return _repository.DeleteUser(userId).Result;
        }
        public GetUserInfoDto? GetUserInfo(Guid userId)
        {
            var user = _repository.GetUserInfo(userId);
            return _mapper.ReturnUserInfoDtoFromDB(user);
        }
        public ResponseDto SaveUserInfo(SaveUserInfoDto userInfoDto, Guid UserId)
        {
            var imageBytes = _imageService.ConvertImage(userInfoDto.ImageRequest!.ProfileImage!);
            var userInfo = _mapper.CreateUserInfo(userInfoDto);
            userInfo.ProfileImage = imageBytes;
            var response = _repository.SaveUserInfo(userInfo, UserId);
            return response;
        }
        public ResponseDto ChangeUserName(string name, Guid userId)
        {
            return _repository.ChangeUserName(name, userId);
        }
        public ResponseDto ChangeUserLastName(string lastName, Guid userId)
        {
            return _repository.ChangeUserLastName(lastName, userId);
        }
        public ResponseDto ChangeUserPersonalNumber(string personalNumber, Guid userId)
        {
            return _repository.ChangeUserPersonalNumber(personalNumber, userId);
        }
        public ResponseDto ChangeUserPhoneNumber(string phoneNumber, Guid userId)
        {
            return _repository.ChangeUserPhoneNumber(phoneNumber, userId);
        }
        public ResponseDto ChangeUserEmail(string email, Guid userId)
        {
            return _repository.ChangeUserEmail(email, userId);
        }
        public ResponseDto ChangeUserProfileImage(ImageRequestDto profileImage, Guid userId)
        {
            var imageBytes = _imageService.ConvertImage(profileImage.ProfileImage!);
            return _repository.ChangeUserProfileImage(imageBytes, userId);
        }
        public ResponseDto ChangeUserCity(string city, Guid userId)
        {
            return _repository.ChangeUserCity(city, userId);
        }
        public ResponseDto ChangeUserStreet(string street, Guid userId)
        {
            return _repository.ChangeUserStreet(street, userId);
        }
        public ResponseDto ChangeUserHouseNumber(int houseNumber, Guid userId)
        {
            return _repository.ChangeUserHouseNumber(houseNumber, userId);
        }
        public ResponseDto ChangeUserApartmentNumber(int apartmentNumber, Guid userId)
        {
            return _repository.ChangeUserApartmentNumber(apartmentNumber, userId);
        }

    }
}
