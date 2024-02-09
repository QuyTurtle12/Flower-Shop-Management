using BusinessObject.Models;
using Repositories;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public User user;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UserRepository userRepository = new UserRepository();
                user = userRepository.Login(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    
                    MessageBox.Show("Login Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomePage homePage = new HomePage(user);
                    homePage.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect User Name or Password", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
