using BusinessObject.Models;
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
    public partial class StaffPage : Form
    {
        private int staffId;
        private int changeEmailCheck = 0;
        private int changePhoneNumCheck = 0;
        public StaffPage(int staffId)
        {
            this.staffId = staffId;
            InitializeComponent();
        }

        private void StaffPage_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            IUserRepository userRepository = new UserRepository();
            User staff = userRepository.GetUserById(staffId);

            txtEmail.Text = staff.Email;
            txtFullName.Text = staff.Fullname;
            txtGender.Text = staff.Gender;
            txtPhoneNumber.Text = staff.PhoneNumber;
            txtRole.Text = staff.Role;
            txtUserId.Text = staff.Id.ToString();

            txtEmail.ReadOnly = changeEmailCheck == 0 ? true : false;
            txtPhoneNumber.ReadOnly = changePhoneNumCheck == 0 ? true : false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();

            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !txtEmail.Text.Contains("@") || // Simple email format check
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please check your inputs and ensure all fields are filled out correctly.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Change Email and Change Phone Number
            if (changeEmailCheck == 1 && changePhoneNumCheck == 1)
            {
                if (!IsValidEmail(txtEmail))
                {
                    MessageBox.Show("Please enter a valid email address.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!userRepository.IsNotExistedPhoneNum(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Existed Phone Number!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User editedStaffInfo = new User
                {
                    Id = staffId,
                    Email = txtEmail.Text,
                    Fullname = txtFullName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                };
                if (editedStaffInfo != null)
                {
                    userRepository.UpdateStaffInfo(editedStaffInfo);
                    MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error at Update method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Only Change Phone Number
            else if (changeEmailCheck == 0 && changePhoneNumCheck == 1)
            {
                if (!userRepository.IsNotExistedPhoneNum(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Existed Phone Number!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User editedStaffInfo = new User
                {
                    Id = staffId,
                    Email = txtEmail.Text,
                    Fullname = txtFullName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                };
                if (editedStaffInfo != null)
                {
                    userRepository.UpdateStaffInfo(editedStaffInfo);
                    MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error at Update method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Only Change Email
            else if (changeEmailCheck == 1 && changePhoneNumCheck == 0)
            {
                if (!IsValidEmail(txtEmail))
                {
                    MessageBox.Show("Please enter a valid email address.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User editedStaffInfo = new User
                {
                    Id = staffId,
                    Email = txtEmail.Text,
                    Fullname = txtFullName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                };
                if (editedStaffInfo != null)
                {
                    userRepository.UpdateStaffInfo(editedStaffInfo);
                    MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error at Update method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            // Not Change Email and Phone Number
            else if (changeEmailCheck == 0 && changePhoneNumCheck == 0)
            {
                User editedStaffInfo = new User
                {
                    Id = staffId,
                    Email = txtEmail.Text,
                    Fullname = txtFullName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                };
                if (editedStaffInfo != null)
                {
                    userRepository.UpdateStaffInfo(editedStaffInfo);
                    MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error at Update method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            string input = txtFullName.Text;
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
            txtFullName.Text = result;
            txtFullName.Select(txtFullName.Text.Length, 0); // Move cursor to the end of the text box
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

        private void btnEmailChange_Click(object sender, EventArgs e)
        {
            if (changeEmailCheck == 0)
            {
                changeEmailCheck = 1;
                reload();
            }
            else if (changeEmailCheck == 1)
            {
                changeEmailCheck = 0;
                reload();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (changePhoneNumCheck == 0)
            {
                changePhoneNumCheck = 1;
                reload();
            }
            else if (changePhoneNumCheck == 1)
            {
                changePhoneNumCheck = 0;
                reload();
            }
        }
    }
}
