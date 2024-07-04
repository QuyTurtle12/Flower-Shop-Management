using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess
{
    
    public class UserBusiness
    {
        public User Login(string username, string password)
        {
            try
            {
                var userDAO = UserDAO.Instance;
                var user = userDAO.AuthenticateUser(username, password);
                if (user != null)
                {
                    // User authentication successful
                    return user;
                }
                else
                {
                    // Authentication failed
                    throw new Exception("Login failed. Please check your username and password, and ensure your account is active.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

            public static bool IsValidPassword(string password)
            {
                return password.Any(char.IsUpper) &&
                       password.Any(char.IsLower) &&
                       password.Any(char.IsDigit) &&
                       password.Any(ch => !char.IsLetterOrDigit(ch)) &&
                       password.Length >= 8;
            }

            public static bool IsValidEmail(string email)
            {
                try
                {
                    var mailAddress = new MailAddress(email);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
    }
    
}
