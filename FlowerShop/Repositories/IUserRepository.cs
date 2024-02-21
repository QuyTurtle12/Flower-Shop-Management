using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        Dictionary<int, User> GetUserList();
        User GetUserById(int id);
    }
}
