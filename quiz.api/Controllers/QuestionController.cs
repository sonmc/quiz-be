using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using quiz_be.Controllers;
using quiz.entities;
using quiz_be.Services;

namespace quiz_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/questions")]
    public class QuestionController : GeneralController<User, IUserService>
    {
        public QuestionController(IUserService service) : base(service)
        {

        }
    }
}
