using BusinessObject.Models;
using DataAccess;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCustomerInfo : Form
    {
        private User currentUser;
        public frmCustomerInfo(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            txtUsername.Text = currentUser.Username;
            txtFullName.Text = currentUser.Fullname;
            txtEmail.Text = currentUser.Email;
            txtPhoneNumber.Text = currentUser.PhoneNumber;
            cbGender.SelectedItem = currentUser.Gender;
            cbRole.SelectedItem = currentUser.Role;

            txtUsername.Enabled = false;
            cbRole.Enabled = false;
            cbGender.Enabled = false;
        }
        private bool VerifyOldPassword(string oldPassword)
        {
            return oldPassword == currentUser.Password;
        }

        private void SaveChanges(string fullName, string email, string phoneNumber, string gender)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!UserBusiness.IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            currentUser.Fullname = fullName;
            currentUser.Email = email;
            currentUser.PhoneNumber = phoneNumber;

            try
            {
                UserRepository userRepository = new UserRepository();
                userRepository.UpdateUser(currentUser);

                MessageBox.Show("Information updated successfully.");

            }
            catch (Exception ex)
            {
                var innerMessage = ex.InnerException != null ? ex.InnerException.Message : "No inner exception";
                MessageBox.Show($"An error occurred: {ex.Message}\nInner Exception: {innerMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void UpdatePassword(string oldPassword, string newPassword, string confirmPassword)
        {
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm new password do not match.");
                return;
            }

            if (oldPassword == newPassword)
            {
                MessageBox.Show("New password cannot be the same as the old password.");
                return;
            }

            bool isOldPasswordCorrect = VerifyOldPassword(oldPassword);
            if (!isOldPasswordCorrect)
            {
                MessageBox.Show("The old password is incorrect.");
                return;
            }

            if (!UserBusiness.IsValidPassword(newPassword))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase letters, a digit, and a special character.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            currentUser.Password = newPassword;

            try
            {
                UserRepository userRepository = new UserRepository();
                userRepository.UpdateUser(currentUser);

                MessageBox.Show("Password updated successfully.");

            }
            catch (Exception ex)
            {
                var innerMessage = ex.InnerException != null ? ex.InnerException.Message : "No inner exception";
                MessageBox.Show($"An error occurred: {ex.Message}\nInner Exception: {innerMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges(txtFullName.Text, txtEmail.Text, txtPhoneNumber.Text, cbGender.SelectedItem.ToString());
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            UpdatePassword(txtOldPassword.Text, txtNewPassword.Text, txtConfirmNewPassword.Text);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.PasswordChar.Equals('*'))
            {
                txtOldPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtConfirmNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtOldPassword.PasswordChar = '*';
                txtNewPassword.PasswordChar = '*';
                txtConfirmNewPassword.PasswordChar = '*';
            }
        }
    }
}
