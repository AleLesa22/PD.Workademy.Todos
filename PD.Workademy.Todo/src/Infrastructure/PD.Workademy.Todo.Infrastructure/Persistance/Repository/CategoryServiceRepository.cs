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
    public class CategoryServiceRepository : ICategoryServiceRepository
    {
        public static List<Category> categories = new()
        {
                new Category(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                new Category(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                new Category(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
        };

        //Add Category
        public Category AddCategory(Category request)
        {
            Category category = new Category(request.Id, request.Name);
            categories.Add(category);
            return request;
        }

        //Delete Category
        public Category DeleteCategory(Guid Id)
        {
            Category category = categories.Find(x => x.Id == Id);
            categories.Remove(category);
            return category;
        }


        public IEnumerable<Category> GetCategories()
        {
            var getCategories = categories.Select(x => new Category(x.Id, x.Name));
            return getCategories;
        }

        public Category GetCategoryById(Guid Id)
        {
            Category category = categories.Find(x => x.Id == Id);
            return category;
        }

        public Category UpdateCategory(Guid Id, Category request)
        {
            Category category = categories.Find(x => x.Id == Id);
            category.Id = request.Id;
            category.Name = request.Name;
            return category;
        }
    }
}
