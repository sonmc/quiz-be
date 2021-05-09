using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using quiz_be.Controllers;
using quiz.entities;
using quiz_be.Services;

namespace quiz_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/answers")]
    public class AnswerController : GeneralController<User, IUserService>
    {
        public AnswerController(IUserService service) : base(service)
        {

        }
    }
}
