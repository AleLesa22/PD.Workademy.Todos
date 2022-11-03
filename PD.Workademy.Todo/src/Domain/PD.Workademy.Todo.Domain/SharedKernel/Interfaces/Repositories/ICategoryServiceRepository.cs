using PD.Workademy.Todo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories
{
    public interface ICategoryServiceRepository
    {
        IEnumerable<Category> GetCategories();
        Category AddCategory(Category request);
        Category DeleteCategory(Guid Id);
        Category GetCategoryById(Guid Id);
        Category UpdateCategory(Guid Id, Category request);
    }
}
