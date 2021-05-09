using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using quiz_be.Controllers;
using quiz.entities;
using quiz_be.Services;

namespace quiz_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/exams")]
    public class ExamController : GeneralController<User, IUserService>
    {
        public ExamController(IUserService service) : base(service)
        {

        }
    }
}
