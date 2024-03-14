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

        public User AuthenticateUser(string username, string password)
        {
            User user = null;
            try
            {
                using var context = new FlowerShopContext();
                user = context.Users.SingleOrDefault(u => (u.Username == username || u.Email == username) && u.Password == password && u.Status == true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }
        public bool CheckUsernameExists(string username)
        {
            bool isExist = false;
            using (var context = new FlowerShopContext())
            {
                try
                {
                    isExist = context.Users.Any(u => u.Username == username);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return isExist;
            }
        }

        public bool CheckEmailExists(string email)
        {
            try
            {
                using (var context = new FlowerShopContext())
                {
                    return context.Users.Any(u => u.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while checking if the email exists.", ex);
            }
        }

        public int GenerateNewUserId()
        {
            int newUserId;
            try
            {
                using (var context = new FlowerShopContext())
                {
                    int lastCustomerId = context.Users.Max(c => c.Id); // Retrieve the last used User Id
                    newUserId = lastCustomerId + 1; // Increment it by 1 to generate a new User Id
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return newUserId;
        }

        public void AddUser(User user)
        {
            using (var context = new FlowerShopContext())
            {
                User newUser = new User()
                {
                    Id = GenerateNewUserId(),
                    Username = user.Username,
                    Password = user.Password,
                    Fullname = user.Fullname,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Gender = user.Gender,
                    Role = user.Role,
                    Status = user.Status,
                };
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        public void DeleteUser(User user) {
            using (var context = new FlowerShopContext())
            {

                context.Users.Remove(user);
                context.SaveChanges();
            }

        }
        public void UpdateUser(User user) {
            using (var context = new FlowerShopContext())
            {

                context.Users.Update(user);
                context.SaveChanges();
            }
        }
    }
}
