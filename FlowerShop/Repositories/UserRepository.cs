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
        public void AddUser(User user) => UserDAO.Instance.AddUser(user);
        public bool CheckUsernameExists(string username) => UserDAO.Instance.CheckUsernameExists(username);
        public void DeleteUser(User user) => UserDAO.Instance.DeleteUser(user);
        public void DisableStatus(int userId) => UserDAO.Instance.DisableStatus(userId);
        public void EnableStatus(int userId) => UserDAO.Instance.EnableStatus(userId);
        public User GetUserById(int id) => UserDAO.Instance.GetUserById(id);
        public Dictionary<int, User> GetUserList() => UserDAO.Instance.GetUserList();
        public void UpdateUser(User user) => UserDAO.Instance.UpdateUser(user);
        public bool IsNotExistedMail(string email) => UserDAO.Instance.IsNotExistedMail(email);
        public void UpdateStaffInfo(User editedUser) => UserDAO.Instance.UpdateStaffInfo(editedUser);
        public bool IsNotExistedPhoneNum(string phoneNum) => UserDAO.Instance.IsNotExistedPhoneNum(phoneNum);
    }
}
