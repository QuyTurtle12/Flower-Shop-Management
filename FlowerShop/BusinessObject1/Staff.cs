using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    internal class Staff : User
    {
        //Staff role is ST - Example: ST001
        public bool Status {  get; set; }
        public Staff(string userID, string userName, string password, string email, string phone, string gender, string role, bool status) : base(userID, userName, password, email, phone, gender, role)
        {
            Status = status;
        }

        public Staff() { }

        public override string ToString()
        {
            return $"ID:{UserID}|Name:{UserName}|Password:***|Email:{Email}|Phone:{Phone}|Gender:{Gender}|Role:{Role}|Status:{Status}";
        }
    }
}
