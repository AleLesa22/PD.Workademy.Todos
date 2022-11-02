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
    }
}
