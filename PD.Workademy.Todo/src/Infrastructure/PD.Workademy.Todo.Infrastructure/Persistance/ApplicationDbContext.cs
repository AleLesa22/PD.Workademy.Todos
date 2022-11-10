using Microsoft.EntityFrameworkCore;
using PD.Workademy.Todo.Domain.Entities;

namespace PD.Workademy.Todo.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //entities
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> Todoitems { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasOne(b => b.Category).WithMany(a => a.TodoItems).OnDelete(DeleteBehavior.Restrict);
        }

    }
}
