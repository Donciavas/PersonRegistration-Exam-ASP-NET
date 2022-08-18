using Microsoft.AspNetCore.Http;

namespace PersonRegistrationASPNet.BusinessLogic.Services
{
    public interface IImageService
    {
        byte[] ConvertImage(IFormFile image);
    }
}
