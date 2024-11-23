using Api_BanQuanAo.Entities;
using Api_BanQuanAo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api_BanQuanAo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly QuanaoContext _context;
        private readonly string? _configuration;

        //public UserController(QuanaoContext context, IConfiguration configuration)
        //{
        //    _context = context;
        //    _configuration = configuration["AppSettings:SecretKey"];
        //}

        //[HttpPost]
        //public async Task<IActionResult> Validate(LoginModel model)
        //{
        //    var user = await _context.Users.SingleOrDefaultAsync(p => p.UserName == model.UserName && p.Password == model.Password);
        //    if(user == null)
        //    {
        //        return Ok(new
        //        {
        //            Success = false,
        //            Message = "Invalid Username/Password"
        //        });
        //    }

        //    return Ok(new
        //    {
        //        Success = true,
        //        Message = "Authenticate success",
        //        Data = GenerateToken(user)
        //    });
        //}

        //private string GenerateToken(User user)
        //{
        //    var jwtTokenHandler = new JwtSecurityTokenHandler();

        //    var secretKeyBytes = Encoding.UTF8.GetBytes(_configuration);

        //    var tokenDescription = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new[] {
        //            new Claim("UserName", user.UserName),
        //            new Claim("Id", user.Id.ToString()),

        //            //roles

        //            new Claim("TokenId", Guid.NewGuid().ToString())
        //        }),
        //        Expires = DateTime.UtcNow.AddMinutes(10),
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var token = jwtTokenHandler.CreateToken(tokenDescription);

        //    return jwtTokenHandler.WriteToken(token);
        //}
    }

}


