using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;
using PD.Workademy.Todo.Web.Service;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class TodoItemController : ApiBaseController
    {
        TodoItemService todoItemService = new TodoItemService();


        [HttpPost("/addTodoItem")]
        public async Task<ActionResult> AddTodoItem([FromBody] TodoItemDTO request)
        {
            todoItemService.AddTodoItem(request);
            return Ok(todoItemService.GetTodoItem(request.Id));
        }


        [HttpGet("/getTodoItemById/{Id}")]
        public async Task<ActionResult> GetTodoItemById(Guid Id)
        {
            return Ok(todoItemService.GetTodoItem(Id));
        }

        [HttpDelete("/deleteTodoItemById/{Id}")]
        public async Task<ActionResult> deleteTodoItem(Guid Id)
        {
            todoItemService.DeleteTodoItem(Id);
            return Ok();
        }


        [HttpPut("/updateTodoItem/{Id}")]
        public async Task<ActionResult> updateTodoItem(Guid Id, TodoItemDTO request)
        {
            todoItemService.UpdateTodoItem(Id, request);
            return Ok(todoItemService.GetTodoItem(Id));
        }
    }
}
