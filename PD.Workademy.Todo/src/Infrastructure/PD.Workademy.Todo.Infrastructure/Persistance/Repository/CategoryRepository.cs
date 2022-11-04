using PD.Workademy.Todo.Application.Services;
using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Web.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Infrastructure.Persistance.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Add Category
        public Category AddCategory(Category request)
        {
            _dbContext.Categories.Add(request);
            _dbContext.SaveChanges();

            return request;
        }

        //Delete Category
        public Category DeleteCategory(Guid Id)
        {
            Category categoryToDelete = _dbContext.Categories.First(x => x.Id == Id);
            _dbContext.Categories.Remove(categoryToDelete);
            _dbContext.SaveChanges();

            return categoryToDelete;
        }


        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.Categories;
        }

        public Category GetCategoryById(Guid Id)
        {
            Category category = _dbContext.Categories.First(x => x.Id == Id);
            return category;
        }

        public Category UpdateCategory(Category request)
        {
            Category category = _dbContext.Categories.First(x => x.Id == request.Id);
            category.Id = request.Id;
            category.Name = request.Name;
            _dbContext.SaveChanges();
            return category;
        }
    }
}
