using System.Diagnostics;

namespace PD.Workademy.Todo.Web.ApiModels
{
    public class UserDTO
    {
        public Guid Id { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserDTO(Guid Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;    
        }

        public UserDTO()
        {

        }
    }
}
