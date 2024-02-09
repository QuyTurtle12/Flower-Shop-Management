using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO
    {
        //Singleton pattern
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }
        public Dictionary<int, User> GetUserList()
        {
            Dictionary<int, User > listUser = new Dictionary<int, User>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    listUser = context.Users.ToDictionary(User => User.Id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
            return listUser;
        }

        public User GetUserById(int id)
        {
            User user = null;
            try
            {
                using var context = new FlowerShopContext();
                user = context.Users.SingleOrDefault(u => u.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public void AddUser(User user) { }
        public void DeleteUser(User user) { }
        public void UpdateUser(User user) { }

        public User Login(string username, string password)
        {
            // Assuming dbContext is your DbContext instance to interact with the database
            using (var dbContext = new FlowerShopContext())
            {
                // Query the database to find the user with the provided username and password
                User user = dbContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                // Return the user if found, otherwise return null
                return user;
            }
        }
    }
}
