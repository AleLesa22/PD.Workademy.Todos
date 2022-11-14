using PD.Workademy.Todo.Domain.SharedKernel;
using System.Reflection;

namespace PD.Workademy.Todo.Domain.Entities
{
    public class TodoItem : BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
        public TodoItem()
        {

        }
        public TodoItem(Guid Id, string Title, string Description, bool IsDone, Category category, User user)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.IsDone = IsDone;
            this.Category = category;
            this.User = user;
        }

        public object this[string propertyName]
        {
            get
            {
                PropertyInfo property = GetType().GetProperty(propertyName);
                return property.GetValue(this, null);
            }
            set
            {
                PropertyInfo property = GetType().GetProperty(propertyName);
                property.SetValue(this, value, null);
            }
        }
    }
}
