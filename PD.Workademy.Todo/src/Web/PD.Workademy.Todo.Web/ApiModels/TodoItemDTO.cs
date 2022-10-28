namespace PD.Workademy.Todo.Web.ApiModels
{
    public class TodoItemDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; private set; }
        public CategoryDTO Category { get; set; }
        public UserDTO User { get; set; }
    }
}
