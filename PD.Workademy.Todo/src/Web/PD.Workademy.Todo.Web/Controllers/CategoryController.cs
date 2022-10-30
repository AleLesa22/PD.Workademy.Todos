using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    
    [ApiController]
    public class CategoryController : ApiBaseController
    {
        
        //ENDPOINTS POST,GET,PUT,DELETE
        [HttpGet]
        public async Task<ActionResult> GetAllCategories()
        {
            List<CategoryDTO> GetAllCategories()
            {
                List<CategoryDTO> Categories = new List<CategoryDTO>() 
                {

                new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),


                new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),


                new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                };
                return Categories;
            }
            return Ok(GetAllCategories());
        }


        [HttpPost]
        public async Task<ActionResult> AddCategory([FromBody] CategoryDTO request)
        {
            List<CategoryDTO> AddCategory(CategoryDTO request)
            {
                List<CategoryDTO> Categories = new List<CategoryDTO>()
                {

                new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),


                new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),


                new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                };

                Categories.Add(request);
                return Categories;
            }
            return Ok(AddCategory(request));
        }


        [HttpGet("/GetCategoryById")]
        public async Task<ActionResult> GetCategoryById(Guid Id)
        {
            CategoryDTO GetCategory(Guid Id)
            {
                CategoryDTO categoryDTO = new CategoryDTO();
                List<CategoryDTO> Categories = new List<CategoryDTO>()
                    {
                     new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                     new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                     new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                    };
                categoryDTO = Categories.Find(x => x.Id == Id);
                return categoryDTO;
            }
            return Ok(GetCategory(Id));
        }


        [HttpDelete]
        public async Task<ActionResult> DeleteCategory(Guid Id)
        {
            List<CategoryDTO> DeleteCategory(Guid Id)
            {
                CategoryDTO categoryDTO = new CategoryDTO();
                List<CategoryDTO> Categories = new List<CategoryDTO>()
                {
                     new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                     new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                     new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                };
                categoryDTO = Categories.Find(x => x.Id == Id);
                Categories.Remove(categoryDTO);
                return Categories;
            }
            return Ok(DeleteCategory(Id));
            
        }


        [HttpPut]
        public async Task<ActionResult> UpdateCategory(Guid Id, CategoryDTO request)
        {
            List<CategoryDTO> UpdateCategory(Guid Id, CategoryDTO request)
            {
                    CategoryDTO categoryDTO = new CategoryDTO();
                    List<CategoryDTO> Categories = new List<CategoryDTO>()
                    {
                        new CategoryDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Easy"),
                        new CategoryDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Medium"),
                        new CategoryDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Hard")
                    };
                    categoryDTO = Categories.Find(x => x.Id == Id);
                    categoryDTO.Id = request.Id;
                    categoryDTO.Name = request.Name;
                    return Categories;
            }
            return Ok(UpdateCategory(Id, request));
        }



    }
}
