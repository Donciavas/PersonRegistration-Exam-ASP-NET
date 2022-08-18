using AutoFixture;
using AutoFixture.Xunit2;
using Moq;
using PersonRegistrationASPNet.Api.Controllers;
using PersonRegistrationASPNet.BusinessLogic.DTOs;
using PersonRegistrationASPNet.BusinessLogic.Services;
using PersonRegistrationASPNet.Database.DTOs;
using PersonRegistrationASPNet.Tests.Customization.SpecimenBuilders;
using System;
using Xunit;

namespace PersonRegistrationASPNet.Tests
{
    public class ManagementControllerTest
    {
        private static readonly Fixture _fixture = new Fixture();

        [Theory, AutoData]
        public void ManagementController_UploadUserInfo_ResposeDto_Returns_IsSuccess_True(Guid userId)
        {

            _fixture.Customizations.Add(new SaveUserInfoDtoSpecimenBuilder());
            var seveUserInfoDto = _fixture.Create<SaveUserInfoDto>();
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.SaveUserInfo(seveUserInfoDto, It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.UploadUserInfo(userId, seveUserInfoDto);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_UploadUserInfo_ResposeDto_BadRequest_Type_Name(Guid userId)
        {

            _fixture.Customizations.Add(new SaveUserInfoDtoSpecimenBuilder());
            var seveUserInfoDto = _fixture.Create<SaveUserInfoDto>();
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.SaveUserInfo(seveUserInfoDto, It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.UploadUserInfo(userId, seveUserInfoDto);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_GetUserInfo_Returns_NotNull_GetUserInfoDto(Guid userId, GetUserInfoDto userInfoDto)
        {

            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.GetUserInfo(It.IsAny<Guid>())).Returns(userInfoDto);

            var response = sut.GetUserInfo(userId);
            var userInfo = response?.Value;

            Assert.NotNull(userInfo);
        }
        [Theory, AutoData]
        public void ManagementController_GetUserInfo_GetUserInfoDto_returns_BadRequest_Type_Name(Guid userId)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.GetUserInfo(It.IsAny<Guid>())).Returns((GetUserInfoDto)null!);

            var response = sut.GetUserInfo(userId);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_DeleteUser_ResposeDto_Returns_IsSuccess_True(Guid userId)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.DeleteUser(It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.DeleteUser(userId);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_DeleteUser_Returns_BadRequest_Type_Name(Guid userId)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.DeleteUser(It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.DeleteUser(userId);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeName_ResposeDto_Returns_IsSuccess_True(Guid userId, string name)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserName(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangeName(userId, name);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeName_Returns_BadRequest_Type_Name(Guid userId, string name)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserName(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangeName(userId, name);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeLastName_ResposeDto_Returns_IsSuccess_True(Guid userId, string lastName)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserLastName(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangeLastName(userId, lastName);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeLastName_Returns_BadRequest_Type_Name(Guid userId, string lastName)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserLastName(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangeLastName(userId, lastName);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangePersonalNumber_ResposeDto_Returns_IsSuccess_True(Guid userId, PersonalNumberDto personalNumber)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserPersonalNumber(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangePersonalNumber(userId, personalNumber);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangePersonalNumber_Returns_BadRequest_Type_Name(Guid userId, PersonalNumberDto personalNumber)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserPersonalNumber(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangePersonalNumber(userId, personalNumber);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangePhoneNumber_ResposeDto_Returns_IsSuccess_True(Guid userId, string phoneNumber)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserPhoneNumber(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangePhoneNumber(userId, phoneNumber);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangePhoneNumber_Returns_BadRequest_Type_Name(Guid userId, string phoneNumber)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserPhoneNumber(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangePhoneNumber(userId, phoneNumber);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeEmail_ResposeDto_Returns_IsSuccess_True(Guid userId, EmailDto email)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserEmail(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangeEmail(userId, email);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeEmail_Returns_BadRequest_Type_Name(Guid userId, EmailDto email)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserEmail(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangeEmail(userId, email);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeProfileImage_ResposeDto_Returns_IsSuccess_True(Guid userId)
        {
            _fixture.Customizations.Add(new SaveUserInfoDtoSpecimenBuilder());
            var seveUserInfoDto = _fixture.Create<SaveUserInfoDto>();
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            var profileImage = seveUserInfoDto.ImageRequest;
            managementServiceMoq.Setup(x => x.ChangeUserProfileImage(profileImage!, It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangeProfileImage(userId, profileImage!);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeProfileImage_Returns_BadRequest_Type_Name(Guid userId)
        {
            _fixture.Customizations.Add(new SaveUserInfoDtoSpecimenBuilder());
            var seveUserInfoDto = _fixture.Create<SaveUserInfoDto>();
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            var profileImage = seveUserInfoDto.ImageRequest;
            managementServiceMoq.Setup(x => x.ChangeUserProfileImage(profileImage!, It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangeProfileImage(userId, profileImage!);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeCity_ResposeDto_Returns_IsSuccess_True(Guid userId, string city)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserCity(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangeCity(userId, city);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeCity_Returns_BadRequest_Type_Name(Guid userId, string city)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserCity(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangeCity(userId, city);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeStreet_ResposeDto_Returns_IsSuccess_True(Guid userId, string street)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserStreet(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangeStreet(userId, street);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeStreet_Returns_BadRequest_Type_Name(Guid userId, string street)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserStreet(It.IsAny<string>(), It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangeStreet(userId, street);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeHauseNumber_ResposeDto_Returns_IsSuccess_True(Guid userId, InputIntDto houseNumber)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserHouseNumber(It.IsAny<int>(), It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangeHauseNumber(userId, houseNumber);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeHauseNumber_Returns_BadRequest_Type_Name(Guid userId, InputIntDto houseNumber)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserHouseNumber(It.IsAny<int>(), It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangeHauseNumber(userId, houseNumber);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeApartmentNumber_ResposeDto_Returns_IsSuccess_True(Guid userId, InputIntDto apartmentNumber)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserApartmentNumber(It.IsAny<int>(), It.IsAny<Guid>())).Returns(new ResponseDto(true, "message"));

            var response = sut.ChangeApartmentNumber(userId, apartmentNumber);
            var isSuccess = response.Value?.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void ManagementController_ChangeApartmentNumber_Returns_BadRequest_Type_Name(Guid userId, InputIntDto apartmentNumber)
        {
            var managementServiceMoq = new Mock<IManagementService>();
            var sut = new ManagementController(managementServiceMoq.Object);
            managementServiceMoq.Setup(x => x.ChangeUserApartmentNumber(It.IsAny<int>(), It.IsAny<Guid>())).Returns(new ResponseDto(false, "message"));

            var response = sut.ChangeApartmentNumber(userId, apartmentNumber);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);
        }
    }
}
