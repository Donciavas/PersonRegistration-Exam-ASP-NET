using AutoFixture.Kernel;
using Microsoft.AspNetCore.Http;
using Moq;
using PersonRegistrationASPNet.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonRegistrationASPNet.Tests.Customization.SpecimenBuilders
{
    public class SaveUserInfoDtoSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            if (request is Type type && type == typeof(SaveUserInfoDto))
            {
                var file = new Mock<IFormFile>();
                var sourceImg = File.OpenRead(@"..\..\..\test.jpg");
                var ms = new MemoryStream();
                var writer = new StreamWriter(ms);
                writer.Write(sourceImg);
                writer.Flush();
                ms.Position = 0;
                var fileName = "QQ.png";
                file.Setup(f => f.FileName).Returns(fileName).Verifiable();
                file.Setup(_ => _.CopyToAsync(It.IsAny<Stream>(), It.IsAny<CancellationToken>()))
                    .Returns((Stream stream, CancellationToken token) => ms.CopyToAsync(stream))
                    .Verifiable();
                var inputFile = file.Object;
                var seveUserInfoDto = new SaveUserInfoDto
                {
                    Name = "Test",
                    LastName = "Testing",
                    PersonalId = new PersonalNumberDto { PersonalNumber = "12345678910" },
                    PhoneNumber = "+37066612345",
                    ImageRequest = new ImageRequestDto { ProfileImage = inputFile },
                    City = "Testoniskes",
                    Street = "testu g.",
                    House = new InputIntDto() { Number = 1},
                    Apartment = new InputIntDto() { Number = 1 }
                };
                return seveUserInfoDto;
            }
            return new NoSpecimen();
        }
    }
}
