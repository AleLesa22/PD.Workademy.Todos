using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.Services;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    
    public class CategoryController : ApiBaseController
    {

        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
        public async Task<ActionResult> GetCategoryAsync(Guid Id)
        {
            return Ok(_categoryService.GetCategoryById(Id));
        }

        [HttpPost]
        public async Task<ActionResult> AddCategoryAsync([FromBody]CategoryDTO request)
        {
            return Ok(_categoryService.AddCategory(request));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCategoryAsync(Guid Id)
        {
            return Ok(_categoryService.DeleteCategory(Id));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCategoryAsync(CategoryDTO request)
        {
            return Ok(_categoryService.UpdateCategory(request));
        }

    }
}
