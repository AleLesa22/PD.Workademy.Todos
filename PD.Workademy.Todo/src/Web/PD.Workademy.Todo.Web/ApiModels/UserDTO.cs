using System.Diagnostics;

namespace PD.Workademy.Todo.Web.ApiModels
{
    public class UserDTO
    {
        public Guid Id { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
