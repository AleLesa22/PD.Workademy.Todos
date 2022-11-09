using PD.Workademy.Todo.Web.ApiModels;

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
