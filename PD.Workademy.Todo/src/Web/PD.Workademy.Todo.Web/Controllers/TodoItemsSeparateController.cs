using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Application.Services;

namespace PD.Workademy.Todo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsSeparateController : ApiBaseController
    {
        private readonly ITodoItemService _todoItemService;
        public TodoItemsSeparateController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet]
        public async Task<ActionResult> GetTodoItemsSeparateAsync([FromQuery] TodoItemSeparateDTO todoItemSeparate)
        {
            return Ok(_todoItemService.GetSeparateTodos(todoItemSeparate));
        }

    }
}
