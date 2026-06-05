using FinanceBillingAnalytics.API.DTOs;
using FinanceBillingAnalytics.API.Models;
using FinanceBillingAnalytics.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinanceBillingAnalytics.API.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            if (dto.Email == "admin@finance.com"
                && dto.Password == "Admin123")
            {
                var user = new User
                {
                    UserId = 1,
                    Email = dto.Email,
                    Role = "Admin"
                };

                var token =
                    _jwtService.GenerateToken(user);

                return Ok(new
                {
                    Token = token
                });
            }

            return Unauthorized(
                "Invalid Credentials");
        }
    }
}
