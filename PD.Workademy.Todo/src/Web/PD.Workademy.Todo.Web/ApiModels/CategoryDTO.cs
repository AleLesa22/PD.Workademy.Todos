using System.Security.Principal;

namespace PD.Workademy.Todo.Web.ApiModels
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CategoryDTO(Guid Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public CategoryDTO()
        {

        }

        
    }
}
