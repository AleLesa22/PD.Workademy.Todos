using PD.Workademy.Todo.Domain.SharedKernel;

namespace PD.Workademy.Todo.Domain.Entities
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; }

        public User(Guid Id,string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
        }
    }
}
