using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using quiz.entities;
using quiz_be.Helpers;
using quiz_be.Repositories;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace quiz_be.Services.ServiceImpl
{
    public class UserService : GeneralServiceImpl<User, IUserRepository>, IUserService
    {
        IUserRepository _repository;
        private readonly AppSettings _appSettings;
        public UserService() { }
        public UserService(IUserRepository repository, IOptions<AppSettings> appSettings) : base(repository)
        {
            _repository = repository;
            _appSettings = appSettings.Value;
        }
        public User Login(string username, string password)
        {
            var user = _repository.Login(username, password); 
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

            return user.WithoutPassword();
        }
    }
}
