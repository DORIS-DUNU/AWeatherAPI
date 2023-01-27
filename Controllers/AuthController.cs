using AWeatherAPI.DTO;
using AWeatherAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AWeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO user)
        {
            var register = await _authService.Register(user);
            if (register.ToString().Contains("Successfully")) return Ok(register);
            return BadRequest(register);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            var login = await _authService.Login(model);
            if (login.ToString().Contains("Wrong")) return BadRequest(login);
            return Ok(login);
        }
    }
}

