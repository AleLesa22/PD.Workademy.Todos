using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PD.Workademy.Todo.Web.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class TodoItemController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult> Todo(Guid id)
        {
            List<string> Todo = new List<string>() { "String1" };
            return Ok(Todo);
        }
    }
}
