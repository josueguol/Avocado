using System;
using System.Collections.Generic;
using System.Linq;
using Avocado.Entities;

namespace Avocado.Repositories
{

    public class MemoryRepository : IRepository
    {
        private readonly List<User> users = new()
        {
            new User { Id = Guid.NewGuid(), Username = "rhernandez", Email = "rhernandez@bravo.com", Name = "Ramón", SecondName = "Hernández" },
            new User { Id = Guid.NewGuid(), Username = "mbautista", Email = "mbautista@bravo.com", Name = "Marco", SecondName = "Bautista" },
            new User { Id = Guid.NewGuid(), Username = "isalinas", Email = "isalinas@bravo.com", Name = "Ivan", SecondName = "Salinas" },
            new User { Id = Guid.NewGuid(), Username = "jgutierrez", Email = "jgutierrez@bravo.com", Name = "Josué", SecondName = "Gutiérrez" }
        };

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public User GetUser(Guid id)
        {
            return users.Where(user => user.Id == id).SingleOrDefault();
        }

        public void CreateUser(User user)
        {
            users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var index = users.FindIndex(existingUser => existingUser.Id == user.Id);
            users[index].Email = user.Email ?? users[index].Email;
            users[index].Name = user.Name ?? users[index].Name;
            users[index].SecondName = user.SecondName ?? users[index].SecondName;
        }

        public void DeleteUser(Guid id)
        {
            var index = users.FindIndex(existingUser => existingUser.Id == id);
            users.RemoveAt(index);
        }
    }
}