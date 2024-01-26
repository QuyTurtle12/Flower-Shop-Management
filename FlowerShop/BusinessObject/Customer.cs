using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    internal class Customer: User
    {
        //Customer role is CS - Example: CS001
        public bool Status { get; set; }

        public Customer(string userID, string userName, string password, string email, string phone, string gender, string role, bool status) : base(userID, userName, password, email, phone, gender, role)
        {
            Status = status;
        }

        public Customer() { }

        public override string ToString()
        {
            return $"ID:{UserID}|Name:{UserName}|Password:***|Email:{Email}|Phone:{Phone}|Gender:{Gender}|Role:{Role}|Status:{Status}";
        }
    }
}
