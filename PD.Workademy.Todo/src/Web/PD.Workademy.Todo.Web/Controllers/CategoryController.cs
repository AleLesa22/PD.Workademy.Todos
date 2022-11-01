using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    
    public class CategoryController : ApiBaseController
    {
        //ENDPOINTS POST,GET,PUT,DELETE
        [HttpGet]
        public async Task<ActionResult> GetAllCategoriesAsync()
        {
            List<CategoryDTO> GetAllCategories()
            {
                List<CategoryDTO> categories = new List<CategoryDTO>() 
                {

                new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),


                new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),


                new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                };
                return categories;
            }
            return Ok(GetAllCategories());
        }


        [HttpPost]
        public async Task<ActionResult> AddCategoryAsync([FromBody] CategoryDTO request)
        {
            List<CategoryDTO> AddCategory(CategoryDTO request)
            {
                List<CategoryDTO> categories = new List<CategoryDTO>()
                {

                new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),


                new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),


                new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                };

                categories.Add(request);
                return categories;
            }
            return Ok(AddCategory(request));
        }


        [HttpGet("/GetCategoryById")]
        public async Task<ActionResult> GetCategoryByIdAsync(Guid Id)
        {
            CategoryDTO GetCategory(Guid Id)
            {
                CategoryDTO categoryDTO = new CategoryDTO();
                List<CategoryDTO> categories = new List<CategoryDTO>()
                    {
                     new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                     new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                     new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                    };
                categoryDTO = categories.Find(x => x.Id == Id);
                return categoryDTO;
            }
            return Ok(GetCategory(Id));
        }


        [HttpDelete]
        public async Task<ActionResult> DeleteCategoryAsync(Guid Id)
        {
            List<CategoryDTO> DeleteCategory(Guid Id)
            {
                CategoryDTO categoryDTO = new CategoryDTO();
                List<CategoryDTO>  categories = new List<CategoryDTO>()
                {
                     new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                     new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                     new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                };
                categoryDTO =  categories.Find(x => x.Id == Id);
                categories.Remove(categoryDTO);
                return categories;
            }
            return Ok(DeleteCategory(Id));
            
        }


        [HttpPut]
        public async Task<ActionResult> UpdateCategoryAsync(Guid Id, CategoryDTO request)
        {
            List<CategoryDTO> UpdateCategory(Guid Id, CategoryDTO request)
            {
                    CategoryDTO categoryDTO = new CategoryDTO();
                    List<CategoryDTO> categories = new List<CategoryDTO>()
                    {
                        new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                        new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                        new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                    };
                    categoryDTO = categories.Find(x => x.Id == Id);
                    categoryDTO.Id = request.Id;
                    categoryDTO.Name = request.Name;
                    return categories;
            }
            return Ok(UpdateCategory(Id, request));
        }



    }
}
