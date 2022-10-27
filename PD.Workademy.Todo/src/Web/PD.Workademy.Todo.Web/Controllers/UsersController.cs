using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PD.Workademy.Todo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult> Users()
        {
            List<string> UserList = new List<string>() { "User1", "User2", "User3" };
            await Task.Run(() =>
            {
                UserList.Add("User4");
            });
            return Ok(UserList);
        }

    }
}
