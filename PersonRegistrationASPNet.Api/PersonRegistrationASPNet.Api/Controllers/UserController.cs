using Microsoft.AspNetCore.Mvc;
using PersonRegistrationASPNet.Api.Models;
using PersonRegistrationASPNet.Api.Services;
using PersonRegistrationASPNet.BusinessLogic.DTOs;
using PersonRegistrationASPNet.BusinessLogic.Services;
using PersonRegistrationASPNet.Database.DTOs;

namespace PersonRegistrationASPNet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        
        private readonly IUserService _userService;
        private readonly IJwtService _jwtService;

        public static Guid UserId { get; set; }

        public UserController(IUserService userService, IJwtService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }
        [HttpPost("Login")]
        public ActionResult<(ResponseDto, JwtToken)> Login([FromBody] UserDto userDto)
        {
            string role;
            var response = _userService.Login(userDto!.Username!, userDto!.Password!, out role);
            if (!response.IsSuccess)
                return BadRequest(response);
            var token = new JwtToken()
            {
                Token = _jwtService.GetJwtToken(userDto.Username!, role),
                UserId = _userService.GetUserID(userDto.Username!)
            };
            return Ok(token);
        }
        [HttpPost("Signup")]
        public ActionResult<ResponseDto> Signup([FromBody] UserDto userDto)
        {
            var response = _userService.Signup(userDto.Username!, userDto.Password!);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
    }
}
