using BusinessObject.Models;
using DataAccess;
using Repositories;
using System.Net.Mail;

namespace GUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // Strong Password Validation - adjust as needed


        private void btnRegister_Click(object sender, EventArgs e)
        {

            // Individual checks for each field for detailed error messages
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name cannot be empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !UserBusiness.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone number cannot be empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UserBusiness.IsValidPassword(txtPassword.Text))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase letters, a digit, and a special character.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var userDAO = UserDAO.Instance;

            // Check if username exists
            if (userDAO.CheckUsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if  email exists
            if (userDAO.CheckEmailExists(txtEmail.Text)) 
            {
                MessageBox.Show("Email already exists. Please choose a different one.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Create New User
            User newUser = new User
            {
                // Set properties based on your User model
                Fullname = $"{txtFirstName.Text} {txtLastName.Text}",
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Gender = cbGender.SelectedItem.ToString(),
                Role = "Customer",
                Status = true // status active by default
            };

            try
            {
                UserRepository userRepository = new UserRepository();
                userRepository.AddUser(newUser);

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                var innerMessage = ex.InnerException != null ? ex.InnerException.Message : "No inner exception";
                MessageBox.Show($"An error occurred: {ex.Message}\nInner Exception: {innerMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordFields_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblPasswordMismatch.Visible = true; // Assume you have a label for showing the mismatch message
                lblPasswordMismatch.Text = "Passwords do not match.";
                lblPasswordMismatch.ForeColor = Color.Red; // Set the text color to red (or any indication color)
            }
            else if (txtPassword.Text.Length < 8)
            {
                lblPasswordMismatch.Text = "Password must be at least 8 characters long.";
            }
            else
            {
                lblPasswordMismatch.Visible = false;
            }
        }

        private void btnAlreadyAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!UserBusiness.IsValidEmail(txtEmail.Text))
            {
                lblPasswordMismatch.Visible = true;
                lblPasswordMismatch.Text = "Invalid email format.";
                lblPasswordMismatch.ForeColor = Color.Red; // Use red color to indicate an error
            }
            else
            {
                lblPasswordMismatch.Visible = false;
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
