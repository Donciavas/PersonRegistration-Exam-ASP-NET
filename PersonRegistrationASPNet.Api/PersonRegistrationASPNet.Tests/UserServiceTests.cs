using AutoFixture;
using AutoFixture.Xunit2;
using Moq;
using PersonRegistrationASPNet.BusinessLogic.Services;
using PersonRegistrationASPNet.Database.Models;
using PersonRegistrationASPNet.Database.Repositories;
using PersonRegistrationASPNet.Tests.Customization.SpecimenBuilders;
using Xunit;

namespace PersonRegistrationASPNet.Tests
{
    public class UserServiceTests
    {
        [Theory, AutoData]
        public void UserService_Login_Returns_ResponseDto_IsSuccess_False_When_User_In_Database_Not_Found(string username, string password)
        {
            var userRepositoryMoq = new Mock<IUserRepository>();
            string role;
            var sut = new UserService(userRepositoryMoq.Object);
            userRepositoryMoq.Setup(x => x.GetUser(It.IsAny<string>())).Returns((User)null!);
            var response = sut.Login(username, password, out role);
            var isSuccess = response.IsSuccess;

            Assert.False(isSuccess);

        }
        [Theory, AutoData]
        public void UserService_Login_Returns_ResponseDto_IsSuccess_Correct_Message_When_User_In_Database_Found_But_password_Wrong(string username, string password)
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new UserSpecimenBuilder());
            var user = fixture.Create<User>();

            var userRepositoryMoq = new Mock<IUserRepository>();
            string role;
            var sut = new UserService(userRepositoryMoq.Object);
            userRepositoryMoq.Setup(x => x.GetUser(It.IsAny<string>())).Returns(user);
            var response = sut.Login(username, password, out role);
            var message = response.Message;

            Assert.Equal("Username or Password does not match", message);

        }
        [Fact]
        public void UserService_Login_Returns_ResponseDto_IsSuccess_true_When_User_In_Database_And_password_OK()
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new UserSpecimenBuilder());
            var user = fixture.Create<User>();

            var userRepositoryMoq = new Mock<IUserRepository>();
            string role;
            var sut = new UserService(userRepositoryMoq.Object);
            userRepositoryMoq.Setup(x => x.GetUser(It.IsAny<string>())).Returns(user);
            var response = sut.Login("Test", "test123", out role);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);
        }
        [Theory, AutoData]
        public void UserService_Singup_Returns_ResponseDto_IsSuccess_False_When_User_In_Database_Found(string username, string password, User user)
        {
            var userRepositoryMoq = new Mock<IUserRepository>();
            var sut = new UserService(userRepositoryMoq.Object);
            userRepositoryMoq.Setup(x => x.GetUser(It.IsAny<string>())).Returns(user);

            var response = sut.Signup(username, password);
            var isSuccess = response.IsSuccess;

            Assert.False(isSuccess);

        }
        [Theory, AutoData]
        public void UserService_Singup_Returns_ResponseDto_IsSuccess_True_When_User_In_Database_Not_Found(string username, string password)
        {
            var userRepositoryMoq = new Mock<IUserRepository>();
            var sut = new UserService(userRepositoryMoq.Object);
            userRepositoryMoq.Setup(x => x.GetUser(It.IsAny<string>())).Returns((User)null!);

            var response = sut.Signup(username, password);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
    }
}
