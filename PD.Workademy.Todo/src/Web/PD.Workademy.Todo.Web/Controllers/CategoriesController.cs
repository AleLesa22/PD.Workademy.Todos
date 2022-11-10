using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Application.Services;

namespace PD.Workademy.Todo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllCategoriesAsync()
        {
            return Ok(_categoryService.GetCategories());
        }
    }
}
