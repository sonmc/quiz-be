using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using quiz_be.Controllers;
using quiz.entities;
using quiz.services;

namespace quiz_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/questions")]
    public class QuestionController : GeneralController<Question, IQuestionService>
    {
        public QuestionController(IQuestionService service) : base(service)
        {

        }
    }
}
