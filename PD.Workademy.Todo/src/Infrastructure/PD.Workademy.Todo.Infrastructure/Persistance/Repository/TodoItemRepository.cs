using Microsoft.EntityFrameworkCore;
using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;

namespace PD.Workademy.Todo.Infrastructure.Persistance.Repository
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public TodoItemRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Add TodoItem
        public TodoItem AddTodoItem(TodoItem request)
        {
            _dbContext.Add(request);
            _dbContext.SaveChanges();

            return _dbContext.Todoitems.First(x => x.Id == request.Id);
        }

        //Delete TodoItem
        public TodoItem DeleteTodoItem(Guid Id)
        {
            TodoItem todoItem = _dbContext.Todoitems.Include(x => x.Category).Include(x => x.User).First(x => x.Id == Id);
            _dbContext.Remove(todoItem);
            _dbContext.SaveChanges();

            return todoItem;
        }

        //Get TodoItem
        public TodoItem GetTodoItemById(Guid Id)
        {
            TodoItem todoItem = _dbContext.Todoitems.Include(x => x.Category).Include(x => x.User).First(x => x.Id == Id);
            return todoItem;
        }

        //Get TodoItems
        public IEnumerable<TodoItem> GetTodoItems()
        {
            return _dbContext.Todoitems.Include(x => x.Category).Include(x => x.User);
        }

        public IEnumerable<TodoItem> GetTodoItemsSeparate(string Search, string SortBy, int Page, int PerPage)
        {
            var todoItems = _dbContext.Todoitems.Include(x => x.Category).Include(x => x.User).OrderBy(x => x[SortBy]).Where(x =>
                           x.Title.Contains(Search)
                        || x.Description.Contains(Search)
                        || x.Category.Name.Contains(Search)
                        || x.User.FirstName.Contains(Search)
                        || x.User.LastName.Contains(Search)).Skip((Page - 1) * PerPage).Take(PerPage).ToList();

            return todoItems;
        }

        //Update TodoItem
        public TodoItem UpdateTodoItem(TodoItem request)
        {
            var todoItemToUpdate = _dbContext.Todoitems.First(x => x.Id == request.Id);
            todoItemToUpdate.Title = request.Title;
            todoItemToUpdate.Description = request.Description;
            todoItemToUpdate.IsDone = request.IsDone;
            todoItemToUpdate.User = request.User;
            todoItemToUpdate.Category = request.Category;

            _dbContext.SaveChanges();
            return todoItemToUpdate;
        }

    }
}
