using PD.Workademy.Todo.Web.ApiModels;

namespace PD.Workademy.Todo.Web.Service
{
    public class UserService
    {
        UserDTO userDTO = new UserDTO();

        static List<UserDTO> Users = new List<UserDTO>();

        public UserDTO UserAleksandar = new UserDTO()
        {
            Id = Guid.NewGuid(),
            FirstName = "Aleksandar",
            LastName = "Vidakovic"
        };
        public UserDTO UserMatija = new UserDTO()
        {
            Id = Guid.NewGuid(),
            FirstName = "Matija",
            LastName = "Davidovic"
        };
        public UserDTO UserNikola = new UserDTO()
        {
            Id = Guid.NewGuid(),
            FirstName = "Nikola",
            LastName = "Djokic"
        };

        //FillUsers
        public void FillUsers()
        {
            Users.Add(UserAleksandar);
            Users.Add(UserMatija);
            Users.Add(UserNikola);
        }

        //AddUser
        public void AddUser(UserDTO request)
        {
            Users.Add(request);
        }


        //DeleteUser
        public void DeleteUser(Guid Id)
        {
            userDTO = Users.Find(x => x.Id == Id);
            Users.Remove(userDTO);
        }

        //GetAllUsers
        public List<UserDTO> GetAllUsers()
        {
            return Users;
        }

        //GetUser
        public UserDTO GetUser(Guid Id)
        {
            userDTO = Users.Find(x => x.Id == Id);
            return userDTO;
        }

        //UpdateUser
        public void UpdateUser(Guid Id, UserDTO request)
        {
            userDTO = Users.Find(x => x.Id == Id);
            userDTO.Id = request.Id;
            userDTO.FirstName = request.FirstName;
            userDTO.LastName = request.LastName;
        }
    }
}
