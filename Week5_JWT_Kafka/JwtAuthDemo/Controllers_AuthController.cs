using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Confluent.Kafka;
using JwtAuthDemo.Models;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "password")
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, model.Username),
                    new Claim(ClaimTypes.Role, "Admin")
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is my test private key"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "MyAuthServer",
                    audience: "MyApiUsers",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds);

                var kafkaConfig = new ProducerConfig { BootstrapServers = "localhost:9092" };
                using var producer = new ProducerBuilder<Null, string>(kafkaConfig).Build();
                await producer.ProduceAsync("logins", new Message<Null, string> { Value = $"User {model.Username} logged in at {DateTime.Now}" });

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            }

            return Unauthorized();
        }

        [HttpGet("/api/secure/data")]
        public IActionResult SecureData() => Ok("✅ This is protected data accessible only with a valid token.");

        [HttpGet("/api/secure/admin")]
        public IActionResult SecureAdmin() => Ok("✅ This is admin-only protected data.");
    }
}