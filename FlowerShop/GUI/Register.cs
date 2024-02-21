using BusinessObject.Models;
using DataAccess;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Fill-in Validation checks
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !txtEmail.Text.Contains("@") || // Simple email format check
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                txtPassword.Text.Length < 8 || // Password length check
                !txtPassword.Text.Any(char.IsDigit) || // Password must contain a number
                txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Please check your inputs and ensure all fields are filled out correctly.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userDAO = UserDAO.Instance;

            // Check if username exists
            if (userDAO.CheckUsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {
                // Set properties based on your User model
                Fullname = txtFirstName.Text + " " + txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Gender = cbGender.SelectedItem.ToString(),
                Role = "Customer",
                Status = true // Assuming active by default
            };

            try
            {
                UserRepository userRepository = new UserRepository();
                userRepository.AddUser(newUser);

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // Log or display the inner exception message if it exists
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
            if (!IsValidEmail(txtEmail.Text))
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
