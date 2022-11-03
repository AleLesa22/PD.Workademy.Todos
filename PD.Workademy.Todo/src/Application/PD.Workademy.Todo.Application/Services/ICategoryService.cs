using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Application.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetCategories();
        CategoryDTO AddCategory(CategoryDTO request);  
        CategoryDTO DeleteCategory(Guid Id);
        CategoryDTO GetCategoryById(Guid Id);
        CategoryDTO UpdateCategory(CategoryDTO request);
    }
}