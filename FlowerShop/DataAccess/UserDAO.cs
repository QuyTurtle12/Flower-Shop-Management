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
                user = context.Users.SingleOrDefault(u => u.Username == username && u.Password == password && u.Status == true);
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

        public bool IsNotExistedMail(string email)
        {
            bool flag = true;
            if (email != null)
            {
                Dictionary<int, User> users = GetUserList();
                List<User> listUser = users.Values.ToList();
                if (listUser.Count > 0)
                {
                    foreach (User user in listUser)
                    {
                        if (user.Email == email)
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool IsNotExistedPhoneNum(string phoneNum)
        {
            bool flag = true;
            if (phoneNum != null)
            {
                Dictionary<int, User> users = GetUserList();
                List<User> listUser = users.Values.ToList();
                if (listUser.Count > 0)
                {
                    foreach (User user in listUser)
                    {
                        if (user.PhoneNumber == phoneNum)
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
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
        public void DeleteUser(User user) { }
        public void UpdateUser(User user) { }

        public void UpdateStaffInfo (User editedUser)
        {
            try
            {
                using (var context = new FlowerShopContext())
                {
                    var user = context.Users.Find(editedUser.Id);
                    user.PhoneNumber = editedUser.PhoneNumber;
                    user.Email = editedUser.Email;
                    user.Fullname = editedUser.Fullname;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"The ID {editedUser.Id} not found");
            }
            
        }
        public void EnableStatus(int userId)
        {
            using (var context = new FlowerShopContext())
            {
                var user = context.Users.Find(userId);
                user.Status = true;
                context.SaveChanges();
            }
        }

        public void DisableStatus(int userId)
        {
            using (var context = new FlowerShopContext())
            {
                var user = context.Users.Find(userId);
                user.Status = false;
                context.SaveChanges();
            }
        }


    }
}
