using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Web.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.Services
{
    public class CategoryService:ICategoryService
    {

        private readonly ICategoryServiceRepository _categoryServiceRepository;
        public CategoryService(ICategoryServiceRepository categoryServiceRepository)
        {
            _categoryServiceRepository = categoryServiceRepository;
        }

        //Add Category
        public CategoryDTO AddCategory(CategoryDTO request)
        {
            Category categoryToAdd = new Category(request.Id, request.Name);
            _categoryServiceRepository.AddCategory(categoryToAdd);

            CategoryDTO category = new CategoryDTO()
            {
                Id = request.Id,
                Name = request.Name,
            };
            return category;
        }
        
        //Delete Category

        public CategoryDTO DeleteCategory(Guid Id)
        {
            Category categoryToDelete = _categoryServiceRepository.DeleteCategory(Id);
            CategoryDTO category = new CategoryDTO(categoryToDelete.Id, categoryToDelete.Name);
            return category;
        }

        //Get All Categories
        public IEnumerable<CategoryDTO> GetCategories()
        {
            var categories = _categoryServiceRepository.GetCategories();
            return categories.Select(x => new CategoryDTO(x.Id, x.Name));
        }

        //Get Category By Id
        public CategoryDTO GetCategoryById(Guid Id)
        {
            Category category = _categoryServiceRepository.GetCategoryById(Id);
            CategoryDTO categoryDTO = new CategoryDTO(category.Id, category.Name);
            return categoryDTO;
        }

        //Update Category By Id
        public CategoryDTO UpdateCategory(Guid Id, CategoryDTO request)
        {
            Category category = _categoryServiceRepository.GetCategoryById(Id);
            category.Id = request.Id;
            category.Name = request.Name;
            CategoryDTO categoryDTO = new CategoryDTO(category.Id, category.Name);
            return categoryDTO;
        }
    }
}
