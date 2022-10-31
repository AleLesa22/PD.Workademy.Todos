using PD.Workademy.Todo.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; }
    }
}
