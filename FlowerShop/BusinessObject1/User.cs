namespace BusinessObject
{
    public class User
    {
        //Template for customer, staff, admin
        public string UserID { get; set; }
        public string UserName {  get; set; }
        public string Password {  get; set; }
        public string Email {  get; set; }
        public string Phone {  get; set; }
        public string Gender {  get; set; }
        public string Role {  get; set; }

        public User(string userID, string userName, string password, string email, string phone, string gender, string role)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Email = email;
            Phone = phone;
            Gender = gender;
            Role = role;
        }

        public User() { }
    }
}
