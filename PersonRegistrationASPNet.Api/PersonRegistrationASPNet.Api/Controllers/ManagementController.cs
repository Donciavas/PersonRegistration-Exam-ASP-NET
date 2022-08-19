using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonRegistrationASPNet.BusinessLogic.DTOs;
using PersonRegistrationASPNet.BusinessLogic.Services;
using PersonRegistrationASPNet.Database.DTOs;

namespace PersonRegistrationASPNet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
   
    public class ManagementController : Controller
    {
        private readonly IManagementService _managementService;

        public ManagementController(IManagementService managementService)
        {
            _managementService = managementService;
        }
        [HttpPost("SaveUserInfo")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> UploadUserInfo([FromForm] Guid userId, [FromForm]  SaveUserInfoDto infoDto)
        {
            var response = _managementService.SaveUserInfo(infoDto, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpGet("GetUserInfo")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<GetUserInfoDto> GetUserInfo([FromQuery] Guid userId)
        {
            var response = _managementService.GetUserInfo(userId);
            if (response is null)
                return BadRequest("Bad User Id");
            return response;
        }
        [HttpDelete("DeleteUser")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        public ActionResult<ResponseDto> DeleteUser([FromQuery] Guid userId)
        {
            var response = _managementService.DeleteUser(userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangeName")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangeName([FromQuery] Guid userId, string name)
        {
            var response = _managementService.ChangeUserName(name, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangeLastName")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangeLastName([FromQuery] Guid userId, string lastName)
        {
            var response = _managementService.ChangeUserLastName(lastName, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangePersonalNumber")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangePersonalNumber([FromQuery] Guid userId, PersonalNumberDto personalNumber)
        {
            var response = _managementService.ChangeUserPersonalNumber(personalNumber.PersonalNumber!, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangePhoneNumber")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangePhoneNumber([FromQuery] Guid userId, string phoneNumber)
        {
            var response = _managementService.ChangeUserPhoneNumber(phoneNumber, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangeEmail")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangeEmail([FromQuery] Guid userId, EmailDto email)
        {
            var response = _managementService.ChangeUserEmail(email.Email!, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangeProfileImage")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangeProfileImage([FromForm] Guid userId, [FromForm] ImageRequestDto profileImage)
        {
            var response = _managementService.ChangeUserProfileImage(profileImage, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangeCity")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangeCity([FromQuery] Guid userId, string city)
        {
            var response = _managementService.ChangeUserCity(city, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangeStreet")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangeStreet([FromQuery] Guid userId, string street)
        {
            var response = _managementService.ChangeUserStreet(street, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangeHouseNumber")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangeHouseNumber([FromQuery] Guid userId, InputIntDto houseNumber)
        {
            var response = _managementService.ChangeUserHouseNumber(houseNumber.Number, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPut("ChangeApartmentNumber")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, User")]
        public ActionResult<ResponseDto> ChangeApartmentNumber([FromQuery] Guid userId, InputIntDto apartmentNumber)
        {
            var response = _managementService.ChangeUserApartmentNumber(apartmentNumber.Number, userId);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
    }
}

