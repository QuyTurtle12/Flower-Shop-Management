﻿using BusinessObject.Models;
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

        public void DeleteUser(User user) => UserDAO.Instance.DeleteUser(user);

        public User GetUserById(int id) => UserDAO.Instance.GetUserById(id);

        public Dictionary<int, User> GetUserList() => UserDAO.Instance.GetUserList();

        public User Login(string username, string password) => UserDAO.Instance.Login(username, password);

        public void UpdateUser(User user) => UserDAO.Instance.UpdateUser(user);
    }
}
