using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Controllers
{
    
    [ApiController]
    public class UserController : ApiBaseController
    {
        //ADD USER
        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] UserDTO request)
        {
            List<UserDTO> AddUsers(UserDTO request)
            {
                List<UserDTO> Users = new List<UserDTO>()
                {

                new UserDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Aleksandar","Vidakovic"),


                new UserDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Matija","Davidovic"),


                new UserDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Nikola","Djokic")
                };

                Users.Add(request);
                return Users;
            }
            return Ok(AddUsers(request));
        }

        //DELETE USER
        [HttpDelete]
        public async Task<ActionResult> DeleteUser(Guid Id)
        {
            List<UserDTO> DeleteUser(Guid Id)
            {
                UserDTO userDTO = new UserDTO();
                List<UserDTO> Users = new List<UserDTO>()
                {
                    new UserDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Aleksandar","Vidakovic"),
                    new UserDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Matija","Davidovic"),
                    new UserDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Nikola","Djokic")
                };

                userDTO = Users.Find(x => x.Id == Id);
                Users.Remove(userDTO);
                return Users;
            }
            return Ok(DeleteUser(Id));
        }

        //GET USER
        [HttpGet]
        public async Task<ActionResult> GetUserById(Guid Id)
        {
            UserDTO GetUser(Guid Id)
            {
                UserDTO userDTO = new UserDTO();
                List<UserDTO> Users = new List<UserDTO>()
                    {
                     new UserDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Aleksandar","Vidakovic"),
                     new UserDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Matija","Davidovic"),
                     new UserDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Nikola","Djokic")
                    };
                userDTO = Users.Find(x => x.Id == Id);
                return userDTO;
            }
            return Ok(GetUser(Id));
        }


        //UPDATE USER
        [HttpPut]
        public async Task<ActionResult> UpdateUser(Guid Id, UserDTO request)
        {
            List<UserDTO> UpdateUser(Guid Id, UserDTO request)
            {
                UserDTO userDTO = new UserDTO();
                List<UserDTO> Users = new List<UserDTO>()
                    {
                     new UserDTO(new Guid("747394a8-3712-4743-a2d1-521d2df10223"), "Aleksandar","Vidakovic"),
                     new UserDTO(new Guid("e7efd2aa-ceac-45af-9421-7cb0d95ab272"), "Matija","Davidovic"),
                     new UserDTO(new Guid("c81382f5-55ae-4617-b911-9a48f9bb5892"), "Nikola","Djokic")
                    };
                userDTO = Users.Find(x => x.Id == Id);
                userDTO.Id = request.Id;
                userDTO.FirstName = request.FirstName;
                userDTO.LastName = request.LastName;
                return Users;
            }
            return Ok(UpdateUser(Id, request));
        }



    }
}
