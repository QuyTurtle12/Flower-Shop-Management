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
        public static Dictionary<string, User> GetUserList()
        {
            Dictionary<string, User > listUser = new Dictionary<string, User>();
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

        public static User GetUserById(string id)
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

        public static void AddUser(User user) { }
        public static void DeleteUser(User user) { }
        public static void UpdateUser(User user) { }
    }
}
