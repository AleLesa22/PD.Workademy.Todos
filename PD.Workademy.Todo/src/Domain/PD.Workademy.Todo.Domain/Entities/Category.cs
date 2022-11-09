using PD.Workademy.Todo.Domain.SharedKernel;

namespace PD.Workademy.Todo.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; }

        public Category(Guid Id,string Name)
        {
            this.Name = Name;
            this.Id = Id;
        }
    }
}
