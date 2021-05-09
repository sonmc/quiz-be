using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using quiz_be.Controllers;
using quiz.entities; 
using System;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using quiz.services;
using quiz.constant;
using quiz.helpers;
using quiz.api.Models;

namespace quiz_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/users")]
    public class UserController : GeneralController<User, IUserService>
    {
        private Response response;
        private IUserService _userService;
        private readonly AppSettings _appSettings;
        public UserController(IUserService userService, IOptions<AppSettings> appSettings) : base(userService)
        {
            response = new Response();
            _userService = userService;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public Response Login([FromBody] Authenticate model)
        {
            var user = _userService.Login(model.Username, model.Password); 
            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);
             
            response.Data = user.WithoutPassword();
            if (user != null)
            {
                response.Status = (int)Configs.STATUS_SUCCESS;
                response.Message = "Success";
            }
            else
            {
                response.Status = (int)Configs.STATUS_ERROR;
                response.Message = "Username or Password invalid";
            }
            return response;
        }
    }
}
