using AlexuKkPortfolioAPI.DTOs;
using AlexuKkPortfolioAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlexuKkPortfolioAPI.Controllers
{

    [ApiController]
    [Route("api/auth")] 
    public class AuthController(IAuthService authService) : ControllerBase 
    {

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] LoginDTO dto)
        {
            try
            {

                var user = await authService.Register(dto);


                string token = await authService.Login(dto);

                return StatusCode(StatusCodes.Status201Created, new { token, username = user.Username });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpPost("login")]
        public async Task<ActionResult<object>> Login([FromBody] LoginDTO dto)
        {
            try
            {
                string token = await authService.Login(dto);

                return Ok(new { token });
            }
            catch (UnauthorizedAccessException)
            {

                return Unauthorized(new { message = "Invalid username or password" });
            }
        }
    }
}