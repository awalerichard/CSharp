using System;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories{
    

    public interface IUsersRepository
    {
        User GetUser(Guid id);
        IEnumerable<User> GetUsers();

        void CreateUser(User user);
        void UpdateUser(User updatedUser);

        void DeleteUser(Guid id);
    }
}