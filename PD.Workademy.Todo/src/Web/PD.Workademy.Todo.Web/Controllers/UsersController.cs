using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    
    public class UsersController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetAllOfUsers()
        {
            List<UserDTO> GetAllOfUsers()
            {
                List<UserDTO> users = new List<UserDTO>()
                    {
                     new UserDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Aleksandar","Vidakovic"),
                     new UserDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Matija","Davidovic"),
                     new UserDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Nikola","Djokic")
                    };
                return users;
            }
            return Ok(GetAllOfUsers());
        }
    }
}
