using Microsoft.AspNetCore.Http;
using PersonRegistrationASPNet.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PersonRegistrationASPNet.BusinessLogic.DTOs
{
    public class ImageRequestDto
    {
        [MaxFileSize(6 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".png", ".jpg", ".tiff", ".bmp", ".gif" })]
        [Required]
        public IFormFile? ProfileImage { get; set; }
    }
}
