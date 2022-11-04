using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.Services;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    
    public class UsersController : ApiBaseController
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        //ADD USER
        [HttpGet]
        public async Task<ActionResult> GetAllUsersAsync()
        {
            return Ok(_userService.GetUsers());
        }
    }
}
