using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Service
{
    public class CategoryService
    {
        CategoryDTO categoryDTO= new CategoryDTO();

        static List<CategoryDTO> Categories = new List<CategoryDTO>();

        public CategoryDTO EasyCategory = new CategoryDTO()
        {
            Id = Guid.NewGuid(),
            Name = "Easy"

        };
        public CategoryDTO MediumCategory = new CategoryDTO()
        {
            Id = Guid.NewGuid(),
            Name = "Medium"
        };
        public  CategoryDTO HardCategory = new CategoryDTO()
        {
            Id = Guid.NewGuid(),
            Name = "Hard"
        };

        //FillCategories
        public void FillCategories()
        {
            Categories.Add(EasyCategory);
            Categories.Add(MediumCategory);
            Categories.Add(HardCategory);
        }

        //AddCategory
        public void AddCategory(CategoryDTO request)
        {
            Categories.Add(request);
        }


        //DeleteCategory
        public void DeleteCategory(Guid Id)
        {
            categoryDTO = Categories.Find(x => x.Id == Id);
            Categories.Remove(categoryDTO);
        }
        
        //GetAllCategories
        public List<CategoryDTO> GetAllCategories()
        {
            return Categories;
        }

        //GetCategory
        public CategoryDTO GetCategory(Guid Id)
        {
            categoryDTO = Categories.Find(x => x.Id == Id);
            return categoryDTO;
        }

        //UpdateCategory
        public void UpdateCategory(Guid Id, CategoryDTO request)
        {
            categoryDTO = Categories.Find(x => x.Id == Id);
            categoryDTO.Id = request.Id;
            categoryDTO.Name = request.Name;
        }


    }
}
