using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.Services;

namespace PD.Workademy.Todo.Web.Controllers
{

    public class TodoItemsController : ApiBaseController
    {
        private readonly ITodoItemService _todoItemService;
        private readonly ILogger<TodoItemController> _logger;
        public TodoItemsController(ITodoItemService todoItemService, ILogger<TodoItemController> logger)
        {
            _todoItemService = todoItemService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> GetTodoItemsAsync()
        {
            _logger.LogInformation("GetTodoLogs");
            return Ok(_todoItemService.GetTodoItems());
        }
    }
}
