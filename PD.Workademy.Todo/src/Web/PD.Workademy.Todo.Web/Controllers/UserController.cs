using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.Services;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    
    public class UserController : ApiBaseController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> GetUserAsync(Guid Id)
        {
            return Ok(_userService.GetUserById(Id));
        }

        [HttpPost]
        public async Task<ActionResult> AddUserAsync([FromBody] UserDTO request)
        {
            return Ok(_userService.AddUser(request));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUserAsync(Guid Id)
        {
            return Ok(_userService.DeleteUser(Id));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUserAsync(UserDTO request)
        {
            return Ok(_userService.UpdateUser(request));
        }



    }
}
