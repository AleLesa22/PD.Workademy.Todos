using Microsoft.EntityFrameworkCore;
using PD.Workademy.Todo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace PD.Workademy.Todo.Infrastructure.Persistance
{
    public class ApplicationDbContext: DbContext
    {
        //entities
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> Todoitems { get; set; }

        public DbSet<Category> Categories { get; set; }

        //OnConfiguring method

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Todo;Trusted_Connection=True;");
        }
    }
}
