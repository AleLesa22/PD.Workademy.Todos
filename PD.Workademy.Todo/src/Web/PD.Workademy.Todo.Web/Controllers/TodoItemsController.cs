using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PD.Workademy.Todo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult> Todos()
        {
            List<string> StringsList = new List<string>() { "String1", "String2", "String3" };
            await Task.Run(() =>
            {
                StringsList.Add("String4");
            });
            return Ok(StringsList);
        }
    }
}
