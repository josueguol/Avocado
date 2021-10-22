using System;
using System.Collections.Generic;
using Avocado.Entities;

namespace Avocado.Repositories
{
    public interface IRepository
    {
        User GetUser(Guid id);
        IEnumerable<User> GetUsers();
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(Guid id);
    }
}