using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Service
{
    public class TodoItemService
    {
        TodoItemDTO todoItemDTO = new TodoItemDTO();
        public static CategoryService categoryService = new CategoryService();
        public static UserService userService = new UserService();

        static List<TodoItemDTO> TodoItems = new List<TodoItemDTO>();

        TodoItemDTO TodoItemOne = new TodoItemDTO()
        {
            Id = Guid.NewGuid(),
            Title = "Todo Item One",
            Description = " Description of Todo item one",
            Category = categoryService.EasyCategory,
            User = userService.UserAleksandar
        };
        TodoItemDTO TodoItemTwo = new TodoItemDTO()
        {
            Id = Guid.NewGuid(),
            Title = "Todo Item Two",
            Description = " Description of Todo item two",
            Category=categoryService.MediumCategory,
            User=userService.UserMatija
        };
        TodoItemDTO TodoItemThree = new TodoItemDTO()
        {
            Id = Guid.NewGuid(),
            Title = "Todo Item Three",
            Description = " Description of Todo item three",
            Category = categoryService.HardCategory,
            User = userService.UserNikola
        };

        //FillTodoItems
        public void FillTodoItems()
        {
            TodoItems.Add(TodoItemOne);
            TodoItems.Add(TodoItemTwo);
            TodoItems.Add(TodoItemThree);
        }

        //AddTodoItem
        public void AddTodoItem(TodoItemDTO request)
        {
            TodoItems.Add(request);
        }


        //DeleteTodoItem
        public void DeleteTodoItem(Guid Id)
        {
            todoItemDTO = TodoItems.Find(x => x.Id == Id);
            TodoItems.Remove(todoItemDTO);
        }

        //GetAllTodoItems
        public List<TodoItemDTO> GetAllTodoItems()
        {
            return TodoItems;
        }

        //GetTodoItem
        public TodoItemDTO GetTodoItem(Guid Id)
        {
            todoItemDTO = TodoItems.Find(x => x.Id == Id);
            return todoItemDTO;
        }

        //UpdateTodoItem
        public void UpdateTodoItem(Guid Id, TodoItemDTO request)
        {
            todoItemDTO = TodoItems.Find(x => x.Id == Id);
            todoItemDTO.Id = request.Id;
            todoItemDTO.Title = request.Title;
            todoItemDTO.Description = request.Description;
            todoItemDTO.Category = request.Category;
            todoItemDTO.User = request.User;
        }
    }
}
