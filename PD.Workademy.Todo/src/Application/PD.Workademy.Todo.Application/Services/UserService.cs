using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using PD.Workademy.Todo.Web.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userServiceRepository;
        public UserService(IUserRepository userServiceRepository)
        {
            _userServiceRepository = userServiceRepository;
        }
        

        public UserDTO AddUser(UserDTO request)
        {
            User userToAdd = new User(request.Id, request.FirstName,request.LastName);
            _userServiceRepository.AddUser(userToAdd);

            UserDTO user = new UserDTO()
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
            };
            return user;
        }

        public UserDTO DeleteUser(Guid Id)
        {
            User userToDelete = _userServiceRepository.DeleteUser(Id);
            UserDTO user = new UserDTO(userToDelete.Id, userToDelete.FirstName,userToDelete.LastName);
            return user;
        }

        public UserDTO GetUserById(Guid Id)
        {
            User user = _userServiceRepository.GetUserById(Id);
            UserDTO userDTO = new UserDTO(user.Id, user.FirstName, user.LastName);
            return userDTO;
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            var users = _userServiceRepository.GetUsers();
            return users.Select(x => new UserDTO(x.Id, x.FirstName, x.LastName));
        }

        public UserDTO UpdateUser(UserDTO request)
        {
            User user = new User(request.Id, request.FirstName, request.LastName);
            _userServiceRepository.UpdateUser(user);
            user.Id = request.Id;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;

            UserDTO userDTO = new UserDTO(user.Id, user.FirstName, user.LastName);
            return userDTO;
        }
    }
}
