using PD.Workademy.Todo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.Services
{
    public class CategoryService:ICategoryService
    {
        public List<Category> AddCategory(Category request)
        {
            List<Category> categories = new()
            {
                new Category(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                new Category(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                new Category(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
            };
            categories.Add(request);
            return categories;
        }

        //DeleteCategory

        public List<Category> DeleteCategory(Guid Id)
        {
            List<Category> categories = new()
            {
                new Category(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                new Category(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                new Category(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
            };
            var categoryToDelete = categories.Find(x => x.Id == Id);
            categories.Remove(categoryToDelete);
            return categories;
        }

        //GetCategories
        public List<Category> GetCategories()
        {
            List<Category> categories = new()
            {
                new Category(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                new Category(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                new Category(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
            };
            return categories;
        }


        //GetCategoryById
        public Category GetCategoryById(Guid Id)
        {
            List<Category> categories = new()
            {
                new Category(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                new Category(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                new Category(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
            };
            var categoryToFind = categories.Find(x => x.Id == Id);
            return categoryToFind;
        }

        public Category UpdateCategory(Guid Id,Category request)
        {
            List<Category> categories = new()
            {
                new Category(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                new Category(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                new Category(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
            };
            var categoryToUpdate = categories.Find(x => x.Id == Id);
            categoryToUpdate.Id = request.Id;
            categoryToUpdate.Name = request.Name;

            return categoryToUpdate;
        }
    }
}
