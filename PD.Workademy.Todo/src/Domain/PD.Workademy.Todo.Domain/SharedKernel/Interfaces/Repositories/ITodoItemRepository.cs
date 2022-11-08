using PD.Workademy.Todo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
