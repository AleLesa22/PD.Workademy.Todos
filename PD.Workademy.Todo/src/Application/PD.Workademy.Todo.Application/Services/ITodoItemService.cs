using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Services
{
    public interface ITodoItemService
    {
        IEnumerable<TodoItemDTO> GetTodoItems();
        IEnumerable<TodoItemDTO> GetSeparateTodos(TodoItemSeparateDTO todoItemSeparate);
        TodoItemDTO AddTodoItem(TodoItemDTO request);
        TodoItemDTO DeleteTodoItem(Guid Id);
        TodoItemDTO GetTodoItemById(Guid Id);
        TodoItemDTO UpdateTodoItem(TodoItemDTO request);

    }
}
