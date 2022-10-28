using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.Service;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class TodoItemsController : ApiBaseController
    {
        TodoItemService todosItemService = new TodoItemService();


        [HttpGet("/GetTodos")]
        public async Task<ActionResult> GetUsers()
        {
            return Ok(todosItemService.GetAllTodoItems());
        }
    }
}
