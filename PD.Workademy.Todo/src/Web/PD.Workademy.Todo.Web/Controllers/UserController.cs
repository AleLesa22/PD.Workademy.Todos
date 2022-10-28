using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PD.Workademy.Todo.Web.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class UserController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult> User(Guid id)
        {
            List<string> User = new List<string>() { "User1" };
            return Ok(User);
        }
    }
}
