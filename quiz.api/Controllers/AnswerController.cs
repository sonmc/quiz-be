using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using quiz_be.Controllers;
using quiz.entities;  
using quiz.services;

namespace quiz_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/answers")]
    public class AnswerController : GeneralController<Answer, IAnswerService>
    {
        public AnswerController(IAnswerService service) : base(service)
        {

        }
    }
}
