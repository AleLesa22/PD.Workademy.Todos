using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;
using PD.Workademy.Todo.Web.Service;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class CategoryController : ApiBaseController
    {
        CategoryService categoryService=new CategoryService();
        

        [HttpGet("/GetAllCategories")]
        public async Task<ActionResult> GetAllCategories()
        {
            return Ok(categoryService.GetAllCategories());
        }


        [HttpPost("/addCategory")]
        public async Task<ActionResult> AddCategory([FromBody] CategoryDTO request)
        {
            categoryService.AddCategory(request);
            return Ok(categoryService.GetAllCategories());
        }


        [HttpGet("/getCategoryById/{Id}")]
        public async Task<ActionResult> GetCategoryById(Guid Id)
        {
            return Ok(categoryService.GetCategory(Id)); 
        }


        [HttpDelete("/deleteCategory/{Id}")]
        public async Task<ActionResult> deleteCategory(Guid Id)
        {
            categoryService.DeleteCategory(Id);
            return Ok(categoryService.GetAllCategories());
        }


        [HttpPut("/updateCategory/{Id}")]
        public async Task<ActionResult> updateCategory(Guid Id, CategoryDTO request)
        {
            categoryService.UpdateCategory(Id, request);
            return Ok(categoryService.GetAllCategories());
        }

        
    }
}
