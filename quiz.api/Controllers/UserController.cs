using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using quiz_be.Controllers;
using quiz.entities;
using quiz_be.Services;
using quiz_be.Constant;
using quiz_be.Models;

namespace quiz_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/users")]
    public class UserController : GeneralController<User, IUserService>
    {
        private Response response;
        private IUserService _userService;
        public UserController(IUserService userService) : base(userService)
        {
            response = new Response();
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public Response Login([FromBody] Authenticate model)
        {
            var user = _userService.Login(model.Username, model.Password);
            response.Data = user;
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
