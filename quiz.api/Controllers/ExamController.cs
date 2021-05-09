using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using quiz_be.Controllers;
using quiz.entities;
using quiz.services;

namespace quiz_api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/exams")]
    public class ExamController : GeneralController<Exam, IExamService>
    {
        public ExamController(IExamService service) : base(service)
        {

        }
    }
}
