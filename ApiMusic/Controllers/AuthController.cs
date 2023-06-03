using ApiMusic.Models;
using ApiMusic.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;
        public AuthController(
            IAuthService authService,
            IConfiguration configuration)
        {
            _authService = authService;
            _configuration = configuration;
        }

        [HttpPost("login")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            bool IsAuthenticated = await _authService.Login(
                user.Username,
                user.Password
            );
            if (IsAuthenticated)
            {
                string token = _authService.GetToken(
                    user.Username,
                    _configuration
                );

                return Ok(new { token = token });
            }

            return BadRequest();
        }

        [HttpPost("register")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Card))]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            await _authService.Register(user);

            return Ok();
        }

        [HttpGet("renewtoken")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public IActionResult RenewToken([FromHeader] string token)
        {
            try
            {
                token = _authService.RenewToken(
                    token,
                    _configuration
                );

                return Ok(new { token = token });
            }
            catch (Exception)
            {
                return BadRequest(new { token = "token no valid" });
            }
        }

        [HttpGet("register/usernameAvailable/{username}")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IActionResult> UsernameAvailable(string username)
        {
            bool available = await _authService.CheckUsername(username);

            return Ok(available);
        }

        [HttpGet("register/emailAvailable/{email}")]
        [SwaggerOperation(Summary = "Text")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IActionResult> EmailAvailable(string email)
        {
            bool available = await _authService.CheckEmail(email);

            return Ok(available);
        }
    }
}
