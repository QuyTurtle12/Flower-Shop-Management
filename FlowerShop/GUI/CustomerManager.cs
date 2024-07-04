using BusinessObject.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomerManager : Form
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        private void CustomerManager_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            IUserRepository userRepository = new UserRepository();
            Dictionary<int, User> users = userRepository.GetUserList();
            List<User> customerList = users.Values.Where(u => u.Role.Equals("Customer")).ToList();

            dgvCustomer.DataSource = customerList;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            int userId = GetSelectedUserId();
            IUserRepository userRepository = new UserRepository();
            if (userId != -1)
            {
                userRepository.EnableStatus(userId);
                reload();
                MessageBox.Show("Active Account Successfully!");
            }
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            int userId = GetSelectedUserId();
            IUserRepository userRepository = new UserRepository();
            if (userId != -1)
            {
                userRepository.DisableStatus(userId);
                reload();
                MessageBox.Show("Deactive Account Successfully!");
            }
        }

        private int GetSelectedUserId()
        {
            if (dgvCustomer.CurrentRow != null && dgvCustomer.CurrentRow.Cells["txtID"].Value != null)
            {
                return Convert.ToInt32(dgvCustomer.CurrentRow.Cells["txtID"].Value);
            }
            else
            {
                MessageBox.Show("The selected item does not contain a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbtnActive.Checked = false;
            rdbtnDeactive.Checked = false;
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            rdbtnOther.Checked = false;
            reload();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!rdbtnActive.Checked &&
            !rdbtnDeactive.Checked &&
            !rdbtnMale.Checked &&
            !rdbtnFemale.Checked &&
            !rdbtnOther.Checked)
            {
                reload();
                return;
            }
            else
            {
                string gender = null;
                if (rdbtnMale.Checked) gender = "Male";
                if (rdbtnFemale.Checked) gender = "Female";
                if (rdbtnOther.Checked) gender = "Other";
                //Filter
                if (rdbtnActive.Checked)
                {
                    IUserRepository userRepository = new UserRepository();
                    Dictionary<int, User> users = userRepository.GetUserList();
                    List<User> userList = users.Values.ToList();
                    List<User> sortedUserList = new List<User>();
                    if (gender != null)
                    {
                        foreach (User user in userList)
                        {
                            if (user.Gender.Equals(gender) && user.Role.Equals("Customer") && user.Status == true)
                            {
                                sortedUserList.Add(user);
                            }
                        }
                        dgvCustomer.DataSource = sortedUserList;
                        return;
                    }
                    else
                    {
                        foreach (User user in userList)
                        {
                            if (user.Role.Equals("Customer") && user.Status == true)
                            {
                                sortedUserList.Add(user);
                            }
                        }
                        dgvCustomer.DataSource = sortedUserList;
                        return;
                    }
                }
                if (rdbtnDeactive.Checked)
                {
                    IUserRepository userRepository = new UserRepository();
                    Dictionary<int, User> users = userRepository.GetUserList();
                    List<User> userList = users.Values.ToList();
                    List<User> sortedUserList = new List<User>();
                    if (gender != null)
                    {
                        foreach (User user in userList)
                        {
                            if (user.Gender.Equals(gender) && user.Role.Equals("Customer") && user.Status == false)
                            {
                                sortedUserList.Add(user);
                            }
                        }
                        dgvCustomer.DataSource = sortedUserList;
                        return;
                    }
                    else
                    {
                        foreach (User user in userList)
                        {
                            if (user.Role.Equals("Customer") && user.Status == false)
                            {
                                sortedUserList.Add(user);
                            }
                        }
                        dgvCustomer.DataSource = sortedUserList;
                        return;
                    }
                }
                if (gender != null)
                {
                    IUserRepository userRepository = new UserRepository();
                    Dictionary<int, User> users = userRepository.GetUserList();
                    List<User> userList = users.Values.ToList();
                    List<User> sortedUserList = new List<User>();
                    foreach (User user in userList)
                    {
                        if (user.Gender.Equals(gender) && user.Role.Equals("Customer"))
                        {
                            sortedUserList.Add(user);
                        }
                    }
                    dgvCustomer.DataSource = sortedUserList;
                    return;
                }
            }
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int customerId = GetSelectedUserId();
            frmOrders customerOrder = new frmOrders(customerId);
            customerOrder.FormClosed += (s, args) => this.reload();
            customerOrder.ShowDialog();
        }
    }
}
