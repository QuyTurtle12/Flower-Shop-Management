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
        bool CheckUsernameExists(string username);
        void EnableStatus(int userId);
        void DisableStatus(int userId);
        bool IsNotExistedMail(string email);
        void UpdateStaffInfo(User editedUser);
        bool IsNotExistedPhoneNum(string phoneNum);
    }
}
