using AutoFixture;
using AutoFixture.Xunit2;
using Moq;
using PersonRegistrationASPNet.Api.Controllers;
using PersonRegistrationASPNet.Api.Services;
using PersonRegistrationASPNet.BusinessLogic.DTOs;
using PersonRegistrationASPNet.BusinessLogic.Services;
using PersonRegistrationASPNet.Database.DTOs;
using PersonRegistrationASPNet.Tests.Customization.SpecimenBuilders;
using Xunit;

namespace PersonRegistrationASPNet.Tests
{
    public class UserControllerTest
    {
        [Theory, AutoData]
        public void UserController_Login_Returns_BadRequest_Type_Name(UserDto userDto)
        {
            var fixture = new Fixture();
            var jwtServiceMoq = new Mock<IJwtService>();
            fixture.Customizations.Add(new ResponsDtoSpecimenBuilder());
            var resposseDto = fixture.Create<ResponseDto>();
            string role;
            var userServiceMoq = new Mock<IUserService>();
            var sut = new UserController(userServiceMoq.Object, jwtServiceMoq.Object);
            userServiceMoq.Setup(x => x.Login(userDto.Username!, userDto.Password!, out role)).Returns((ResponseDto)resposseDto);

            var response = sut.Login(userDto);
            var type = response?.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type?.Name);

        }
        [Theory, AutoData]
        public void UserController_Signup_Returns_BadRequest_Type_Name(UserDto userDto)
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new UserSpecimenBuilder());
            var resposseDto = fixture.Create<ResponseDto>();
            var jwtServiceMoq = new Mock<IJwtService>();
            var userServiceMoq = new Mock<IUserService>();
            var sut = new UserController(userServiceMoq.Object, jwtServiceMoq.Object);
            userServiceMoq.Setup(x => x.Signup(It.IsAny<string>(), It.IsAny<string>())).Returns((ResponseDto)resposseDto);

            var response = sut.Signup(userDto);
            var type = response.Result?.GetType();

            Assert.Equal("BadRequestObjectResult", type!.Name);

        }
        [Theory, AutoData]
        public void UserController_Signup_Returns_Respose_Isuccces_Equal_True(UserDto userDto)
        {
            var jwtServiceMoq = new Mock<IJwtService>();
            var userServiceMoq = new Mock<IUserService>();
            var sut = new UserController(userServiceMoq.Object, jwtServiceMoq.Object);
            userServiceMoq.Setup(x => x.Signup(It.IsAny<string>(), It.IsAny<string>())).Returns(new ResponseDto(true, "User registered"));

            var response = sut.Signup(userDto)?.Value?.IsSuccess;

            Assert.True(response);

        }

    }
}
