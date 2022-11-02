using PD.Workademy.Todo.Domain.Entities;

namespace PD.Workademy.Todo.Application.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}