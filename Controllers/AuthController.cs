using System.Net;
using System;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Dtos;
using SchoolApi.Models;
using SchoolApi.Repository;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace SchoolApi.Controllers
{
    
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthRepository authRepository;
        private readonly IConfiguration _config;
        public AuthController(IAuthRepository authRepository, IConfiguration config)
        {
            this._config = config;
            this.authRepository = authRepository;

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userLoginDto)
        {
            var loginCheck = await authRepository.Login(userLoginDto.email, userLoginDto.pass);

            if (loginCheck == null)
                return Unauthorized();
        

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:Token").Value);
            
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier , loginCheck.Id.ToString()),
                    new Claim(ClaimTypes.Name , loginCheck.email)
                }),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                                                            SecurityAlgorithms.HmacSha512Signature
                                                            )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);


            return Ok(new { tokenString });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto userRegisterDto)
        {            

            if (await authRepository.UserExist(userRegisterDto.email))
                ModelState.AddModelError("Username", "Username already exists");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            

            var useToCreate = new UserModel
            {
                email = userRegisterDto.email,
                name = userRegisterDto.name
            };

            var createdUSer = await authRepository.register(useToCreate, userRegisterDto.pass);

            return StatusCode(201);


        }


    }
}