using Microsoft.AspNetCore.Authorization; 
using Microsoft.AspNetCore.Mvc;
using quiz.entities;
using quiz.services;
using quiz_be.Controllers;

namespace quiz_api.Controllers
{ 
    [Authorize]
    [ApiController]
    [Route("api/groups")]
    public class GroupController : GeneralController<Group, IGroupService>
    {
        public GroupController(IGroupService service) : base(service)
        {

        }
    }
}
