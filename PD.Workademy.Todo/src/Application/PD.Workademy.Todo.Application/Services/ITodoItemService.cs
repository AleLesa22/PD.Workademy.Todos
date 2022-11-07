using PD.Workademy.Todo.Web.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.Services
{
    public interface ITodoItemService
    {
        IEnumerable<TodoItemDTO> GetTodoItems();
        TodoItemDTO AddTodoItem(TodoItemDTO request);
        TodoItemDTO DeleteTodoItem(Guid Id);
        TodoItemDTO GetTodoItemById(Guid Id);
        TodoItemDTO UpdateTodoItem(TodoItemDTO request);

    }
}
