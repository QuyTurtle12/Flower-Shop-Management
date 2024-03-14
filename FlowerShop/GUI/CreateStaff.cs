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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class CreateStaff : Form
    {
        public CreateStaff()
        {
            InitializeComponent();
        }

        private void CreateStaff_Load(object sender, EventArgs e)
        {
            
        }

        private bool IsValidEmail(TextBox email)
        {
            IUserRepository userRepository = new UserRepository();
            if (string.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Empty Email Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(email.Text.Count(c => c == '@') == 1))
            {
                MessageBox.Show("Need to contain exactly one '@'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!userRepository.IsNotExistedMail(txtEmail.Text))
            {
                MessageBox.Show("The Email has been existed!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            string pattern = @"^[a-zA-Z0-9@.]+$";
            if (!Regex.IsMatch(email.Text, pattern))
            {
                MessageBox.Show("Email can only contain alphanumeric characters, '.' and '@' symbol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string input = txtFirstName.Text;
            string result = "";

            foreach (char c in input)
            {
                // Check if the character is alphabetic
                if (char.IsLetter(c) || c.Equals(' '))
                {
                    result += c;
                }
            }

            // Update the text box with the filtered result
            txtFirstName.Text = result;
            txtFirstName.Select(txtFirstName.Text.Length, 0); // Move cursor to the end of the text box
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            string input = txtLastName.Text;
            string result = "";

            foreach (char c in input)
            {
                // Check if the character is alphabetic
                if (char.IsLetter(c) || c.Equals(' '))
                {
                    result += c;
                }
            }

            // Update the text box with the filtered result
            txtLastName.Text = result;
            txtLastName.Select(txtLastName.Text.Length, 0); // Move cursor to the end of the text box
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
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
            if (!IsValidEmail(txtEmail))
            {
                MessageBox.Show("Please enter a valid email address.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!userRepository.IsNotExistedPhoneNum(txtPhoneNumber.Text))
            {
                MessageBox.Show("Existed Phone Number!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userDAO = UserDAO.Instance;

            // Check if username exists
            if (userDAO.CheckUsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(cbGender.SelectedItem == null)
            {
                MessageBox.Show("Please select your gender.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {
                Fullname = txtFirstName.Text + " " + txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Gender = cbGender.SelectedItem.ToString(),
                Role = "Staff",
                Status = true
            };

            try
            {
                userRepository.AddUser(newUser);

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
    }
}
