using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;
using PD.Workademy.Todo.Web.Service;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class UsersController : ApiBaseController
    {
        UserService usersService = new UserService();


        [HttpGet("/GetUsers")]
        public async Task<ActionResult> GetUsers()
        {
            return Ok(usersService.GetAllUsers());
        }


    }
}
