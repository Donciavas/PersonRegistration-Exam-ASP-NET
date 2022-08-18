using AutoFixture.Xunit2;
using Moq;
using Moq.EntityFrameworkCore;
using PersonRegistrationASPNet.Database;
using PersonRegistrationASPNet.Database.Models;
using PersonRegistrationASPNet.Database.Repositories;
using System;
using System.Collections.Generic;
using Xunit;

namespace PersonRegistrationASPNet.Tests
{
    public class ManagementRepositoryTest
    {
        [Theory, AutoData]
        public void ManagementRepository_DelateUser_ReturnsDto_Returns_Correct_Message(Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.DeleteUser(userId);
            var message = response.Result.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_DelateUser_ReturnsDto_Returns_true(User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.DeleteUser(user.Id);
            var isSuccess = response.Result.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_SaveUserInfo_ReturnsDto_Returns_Correct_Message(Guid userId, User user, UserInfo userInfo)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.SaveUserInfo(userInfo, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_SaveUserInfo_ReturnsDto_Returns_true(User user, UserInfo userInfo)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.SaveUserInfo(userInfo, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserName_ReturnsDto_Returns_Correct_Message(string name, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserName(name, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserName_ReturnsDto_Returns_true(string name, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserName(name, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserLastName_ReturnsDto_Returns_Correct_Message(string lastName, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserLastName(lastName, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserLastName_ReturnsDto_Returns_true(string lastName, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserLastName(lastName, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserPersonalNumber_ReturnsDto_Returns_Correct_Message(string personalNumber, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserPersonalNumber(personalNumber, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserPersonalNumber_ReturnsDto_Returns_true(string personalNumber, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserPersonalNumber(personalNumber, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserPhoneNumber_ReturnsDto_Returns_Correct_Message(string phoneNumber, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserPhoneNumber(phoneNumber, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserPhoneNumber_ReturnsDto_Returns_true(string phoneNumber, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserPhoneNumber(phoneNumber, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserEmail_ReturnsDto_Returns_Correct_Message(string email, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserEmail(email, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserEmail_ReturnsDto_Returns_true(string email, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserEmail(email, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserProfileImage_ReturnsDto_Returns_Correct_Message(byte[] profileImage, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserProfileImage(profileImage, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserProfileImage_ReturnsDto_Returns_true(byte[] profileImage, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserProfileImage(profileImage, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserCity_ReturnsDto_Returns_Correct_Message(string city, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserCity(city, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserCity_ReturnsDto_Returns_true(string city, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserCity(city, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }

        [Theory, AutoData]
        public void ManagementRepository_ChangeUserStreet_ReturnsDto_Returns_Correct_Message(string street, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserStreet(street, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserStreet_ReturnsDto_Returns_true(string street, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserStreet(street, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserHauseNumber_ReturnsDto_Returns_Correct_Message(int houseNumber, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserHouseNumber(houseNumber, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserHauseNumber_ReturnsDto_Returns_true(int houseNumber, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserHouseNumber(houseNumber, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserApartmentNumber_ReturnsDto_Returns_Correct_Message(int apartmentNumber, Guid userId, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserApartmentNumber(apartmentNumber, userId);
            var message = response.Message;

            Assert.Equal("Bad user Id", message);

        }
        [Theory, AutoData]
        public void ManagementRepository_ChangeUserApartmentNumber_ReturnsDto_Returns_true(int apartmentNumber, User user)
        {
            var users = new List<User>();
            users.Add(user);
            var applicationDbContextMock = new Mock<ApplicationDbContext>();
            applicationDbContextMock.Setup(x => x.Users).ReturnsDbSet(users);
            var sut = new ManagementRepository(applicationDbContextMock.Object);

            var response = sut.ChangeUserApartmentNumber(apartmentNumber, user.Id);
            var isSuccess = response.IsSuccess;

            Assert.True(isSuccess);

        }
    }
}
