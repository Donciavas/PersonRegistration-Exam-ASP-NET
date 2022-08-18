using Microsoft.AspNetCore.Http;
using System.Drawing;

namespace PersonRegistrationASPNet.BusinessLogic.Services
{
    public class ImageService : IImageService
    {
        public byte[] ConvertImage(IFormFile imageRequest)
        {
            using var memoryStream = new MemoryStream();
            imageRequest.CopyTo(memoryStream);
            var stream = imageRequest.OpenReadStream();
            var resizedImage = ResizeImage(200, 200, stream);
            return resizedImage;
        }
        internal byte[] ResizeImage(int width, int height, Stream memmorStream)
        {

            var image = Image.FromStream(memmorStream);
            var thumb = image.GetThumbnailImage(width, height, () => false, IntPtr.Zero);
            var converter = new ImageConverter();
            var resizedImage = (byte[]?)converter.ConvertTo(thumb, typeof(byte[]));
            return resizedImage!;
        }
    }
}
