using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.Services;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    public class TodoItemController : ApiBaseController
    {
        private readonly ITodoItemService _todoItemService;
        public TodoItemController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }


        [HttpGet]
        public async Task<ActionResult> GetCategoryAsync(Guid Id)
        {
            return Ok(_todoItemService.GetTodoItemById(Id));
        }

        [HttpPost]
        public async Task<ActionResult> AddCategoryAsync([FromBody] TodoItemDTO request)
        {
            return Ok(_todoItemService.AddTodoItem(request));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCategoryAsync(Guid Id)
        {
            return Ok(_todoItemService.DeleteTodoItem(Id));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCategoryAsync(TodoItemDTO request)
        {
            return Ok(_todoItemService.UpdateTodoItem(request));
        }
    }

 }

