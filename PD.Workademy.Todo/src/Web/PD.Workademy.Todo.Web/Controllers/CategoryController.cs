using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PD.Workademy.Todo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult> Category()
        {
            List<string> Categories = new List<string>() { "String1", "String2", "String3" };
            return Ok(Categories);
        }
    }
}
