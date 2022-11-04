﻿using PD.Workademy.Todo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User AddUser(User request);
        User DeleteUser(Guid Id);
        User GetUserById(Guid Id);
        User UpdateUser(User request);
    }
}
