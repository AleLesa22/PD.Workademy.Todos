using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;
using PD.Workademy.Todo.Web.Service;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class UserController : ApiBaseController
    {
        UserService userService = new UserService();
        
        
        [HttpPost("/addUser")]
        public async Task<ActionResult> AddUser([FromBody] UserDTO request)
        {
            userService.AddUser(request);
            return Ok(userService.GetUser(request.Id));
        }


        [HttpGet("/getUserById/{Id}")]
        public async Task<ActionResult> GetUserById(Guid Id)
        {
            return Ok(userService.GetUser(Id));
        }

        [HttpDelete("/deleteUser/{Id}")]
        public async Task<ActionResult> deleteUser(Guid Id)
        {
            userService.DeleteUser(Id);
            return Ok();
        }


        [HttpPut("/updateUser/{Id}")]
        public async Task<ActionResult> updateCategory(Guid Id, UserDTO request)
        {
            userService.UpdateUser(Id, request);
            return Ok(userService.GetUser(Id));
        }
    }
}
