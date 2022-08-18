using AutoFixture.Kernel;
using PersonRegistrationASPNet.Database.DTOs;
using System;

namespace PersonRegistrationASPNet.Tests.Customization.SpecimenBuilders
{
    public class ResponsDtoSpecimenBuilder : ISpecimenBuilder 
    {
        public object Create(object request, ISpecimenContext context)
        {
            if (request is Type type && type == typeof(ResponseDto))
            {
                return new ResponseDto (false, "message");
            }
            return new NoSpecimen();
        }
    }
}
