using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    internal class Admin: User
    {
        //Admin role is AD - Example: AD001
        public Admin(string userID, string userName, string password, string email, string phone, string gender, string role) : base(userID, userName, password, email, phone, gender, role)
        {
            
        }

        public Admin() { }
        
        public override string ToString()
        {
            return $"ID:{UserID}|Name:{UserName}|Password:***|Email:{Email}|Phone:{Phone}|Gender:{Gender}|Role:{Role}";
        }
    }
}
