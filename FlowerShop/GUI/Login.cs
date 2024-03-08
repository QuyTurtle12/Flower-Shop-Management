using BusinessObject.Models;
using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var userBusiness = new UserBusiness();

            try
            {
                var user = userBusiness.Login(username, password);
                if (user != null)
                {
                    this.Hide(); 
                    HomePage nextPage = new HomePage(user);
                    nextPage.FormClosed += (s, args) => this.Close();
                    nextPage.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            // this.Hide();
            // registerForm.FormClosed += (s, args) => this.Close();
        }

        private void btnRecoverAccount_Click(object sender, EventArgs e)
        {
            // Navigate to the RecoverAccount form
            RecoverAccount recoverAccountForm = new RecoverAccount();
            recoverAccountForm.Show();
            // Optionally hide the login form, uncomment the line below if you wish to hide it
            // this.Hide();
        }
    }
}
