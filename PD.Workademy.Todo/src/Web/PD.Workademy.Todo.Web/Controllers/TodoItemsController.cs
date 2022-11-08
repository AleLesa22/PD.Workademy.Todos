using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.Services;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    
    public class TodoItemsController : ApiBaseController
    {
        private readonly ITodoItemService _todoItemService;
        public TodoItemsController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet]
        public async Task<ActionResult> GetTodoItemsAsync()
        {
            return Ok(_todoItemService.GetTodoItems());
        }
    }
}
