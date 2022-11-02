using PD.Workademy.Todo.Domain.Entities;

namespace PD.Workademy.Todo.Application.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        List<Category> AddCategory(Category request);  
        List<Category> DeleteCategory(Guid Id);
        Category GetCategoryById(Guid Id);
        Category UpdateCategory(Guid Id,Category request);
    }
}