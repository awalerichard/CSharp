using System;
using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.Repositories
{
    

    public class InMemUsersRepository : IUsersRepository
    {
        private readonly List<User> users = new(){
            new User{Id = Guid.NewGuid(), Username  = "Richard", Password="Thisest", CreatedDate = DateTimeOffset.UtcNow},
           
        };
         public IEnumerable<User> GetItems()
        {
            return users;
        }
        public void CreateUser(User user)
        {
           users.Add(user);
        }

        public void DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid id)
        {
            return users.Where(user => user.Id == id).SingleOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}