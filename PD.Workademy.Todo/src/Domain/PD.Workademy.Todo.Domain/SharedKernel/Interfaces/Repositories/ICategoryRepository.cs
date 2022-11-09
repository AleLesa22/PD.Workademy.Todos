using PD.Workademy.Todo.Domain.Entities;

namespace PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category AddCategory(Category request);
        Category DeleteCategory(Guid Id);
        Category GetCategoryById(Guid Id);
        Category UpdateCategory(Category request);
    }
}
