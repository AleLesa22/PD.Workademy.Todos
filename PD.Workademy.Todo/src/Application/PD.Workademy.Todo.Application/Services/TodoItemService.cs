using PD.Workademy.Todo.Application.ApiModels;
using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ITodoItemRepository _todoItemServiceRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;

        public TodoItemService(ITodoItemRepository todoItemServiceRepository, IUserRepository userRepository, ICategoryRepository categoryRepository)
        {
            _todoItemServiceRepository = todoItemServiceRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
        }

        public TodoItemDTO AddTodoItem(TodoItemDTO request)
        {
            User user = _userRepository.GetUserById(request.User.Id);
            Category category = _categoryRepository.GetCategoryById(request.Category.Id);

            TodoItem todoItem = new TodoItem()
            {
                Id = request.Id,
                Title = request.Title,
                Description = request.Description,
                IsDone = request.IsDone,
                Category = category,
                User = user
            };

            CategoryDTO categoryDTO = new CategoryDTO()
            {
                Id = request.Category.Id,
                Name = request.Category.Name
            };

            UserDTO userDTO = new UserDTO()
            {
                Id = request.User.Id,
                FirstName = request.User.FirstName,
                LastName = request.User.LastName
            };

            TodoItemDTO todoItemDTO = new TodoItemDTO()
            {
                Id = request.Id,
                Title = request.Title,
                Description = request.Description,
                IsDone = request.IsDone,
                Category = categoryDTO,
                User = userDTO
            };

            _todoItemServiceRepository.AddTodoItem(new TodoItem(request.Id, request.Title, request.Description, request.IsDone, category, user));
            return todoItemDTO;
        }

        public TodoItemDTO DeleteTodoItem(Guid Id)
        {
            TodoItem todoItemToDelete = _todoItemServiceRepository.DeleteTodoItem(Id);
            TodoItemDTO todoItemDTO = new TodoItemDTO(todoItemToDelete.Id, todoItemToDelete.Title, todoItemToDelete.Description, todoItemToDelete.IsDone,
                                      new CategoryDTO(todoItemToDelete.Category.Id, todoItemToDelete.Category.Name),
                                      new UserDTO(todoItemToDelete.User.Id, todoItemToDelete.User.FirstName, todoItemToDelete.User.LastName));
            return todoItemDTO;
        }

        public TodoItemDTO GetTodoItemById(Guid Id)
        {
            TodoItem todoItem = _todoItemServiceRepository.GetTodoItemById(Id);
            TodoItemDTO todoItemDTO = new TodoItemDTO(todoItem.Id, todoItem.Title, todoItem.Description, todoItem.IsDone,
                                      new CategoryDTO(todoItem.Category.Id, todoItem.Category.Name),
                                      new UserDTO(todoItem.User.Id, todoItem.User.FirstName, todoItem.User.LastName));
            return todoItemDTO;
        }

        public IEnumerable<TodoItemDTO> GetTodoItems()
        {
            var todoItems = _todoItemServiceRepository.GetTodoItems();
            return todoItems.Select(x => new TodoItemDTO(x.Id, x.Title, x.Description, x.IsDone,
                                         new CategoryDTO(x.Category.Id, x.Category.Name),
                                         new UserDTO(x.User.Id, x.User.FirstName, x.User.LastName)));
        }

        public TodoItemDTO UpdateTodoItem(TodoItemDTO request)
        {
            User user = _userRepository.GetUserById(request.User.Id);
            Category category = _categoryRepository.GetCategoryById(request.Category.Id);
            _todoItemServiceRepository.UpdateTodoItem(new TodoItem(request.Id, request.Title, request.Description, request.IsDone, category, user));
            TodoItemDTO todoItemDTO = new TodoItemDTO(request.Id, request.Title, request.Description, request.IsDone,
                                      new CategoryDTO(request.Category.Id, request.Category.Name),
                                      new UserDTO(request.User.Id, request.User.FirstName, request.User.LastName));

            return todoItemDTO;
        }

        public IEnumerable<TodoItemDTO> GetSeparateTodos(TodoItemSeparateDTO todoItemSeparate)
        {
            string Search = todoItemSeparate.Search ?? "";
            string SortBy = todoItemSeparate.SortBy ?? "Id";
            int Page = todoItemSeparate.Page == null || todoItemSeparate.Page == 0 ? 1 : todoItemSeparate.Page;
            int PerPage = todoItemSeparate.PerPage == null || todoItemSeparate.PerPage == 0 ? 10 : todoItemSeparate.PerPage;
            var todoItems = _todoItemServiceRepository.GetTodoItemsSeparate(Search, SortBy, Page, PerPage);

            IEnumerable<TodoItemDTO> todoItemsDTO = todoItems.Select(x => new TodoItemDTO(x.Id, x.Title, x.Description, x.IsDone,
                                                                          new CategoryDTO(x.Category.Id, x.Category.Name),
                                                                          new UserDTO(x.User.Id, x.User.FirstName, x.User.LastName)));

            return todoItemsDTO;
        }
    }
}
