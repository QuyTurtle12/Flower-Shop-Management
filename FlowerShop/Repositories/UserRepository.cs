using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user) => UserDAO.AddUser(user);

        public void DeleteUser(User user) => UserDAO.DeleteUser(user);

        public User GetUserById(string id) => UserDAO.GetUserById(id);

        public Dictionary<string, User> GetUserList() => UserDAO.GetUserList();

        public void UpdateUser(User user) => UserDAO.UpdateUser(user);
    }
}
