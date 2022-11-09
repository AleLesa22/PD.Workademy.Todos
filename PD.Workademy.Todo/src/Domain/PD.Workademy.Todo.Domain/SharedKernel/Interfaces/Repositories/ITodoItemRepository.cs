using PD.Workademy.Todo.Domain.Entities;

namespace PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories
{
    public interface ITodoItemRepository
    {
        IEnumerable<TodoItem> GetTodoItems();
        TodoItem AddTodoItem(TodoItem request);
        TodoItem DeleteTodoItem(Guid Id);
        TodoItem GetTodoItemById(Guid Id);
        TodoItem UpdateTodoItem(TodoItem request);
    }
}
