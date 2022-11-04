using PD.Workademy.Todo.Web.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.Services
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetUsers();
        UserDTO AddUser(UserDTO request);
        UserDTO DeleteUser(Guid Id);
        UserDTO GetUserById(Guid Id);
        UserDTO UpdateUser(UserDTO request);
    }
}
