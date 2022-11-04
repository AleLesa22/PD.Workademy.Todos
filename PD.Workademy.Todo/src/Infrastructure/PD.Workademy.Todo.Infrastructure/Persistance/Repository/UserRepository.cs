using PD.Workademy.Todo.Domain.Entities;
using PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Infrastructure.Persistance.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //ADD User
        public User AddUser(User request)
        {
            _dbContext.Users.Add(request);
            _dbContext.SaveChanges();

            return request;
        }

        public User DeleteUser(Guid Id)
        {
            User userToDelete = _dbContext.Users.First(x => x.Id == Id);
            _dbContext.Users.Remove(userToDelete);
            _dbContext.SaveChanges();

            return userToDelete;
        }

        public User GetUserById(Guid Id)
        {
            User user = _dbContext.Users.First(x => x.Id == Id);
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users;
        }

        public User UpdateUser(User request)
        {
            User user = _dbContext.Users.First(x => x.Id == request.Id);
            user.Id = request.Id;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            _dbContext.SaveChanges();
            return user;
        }
    }
}
