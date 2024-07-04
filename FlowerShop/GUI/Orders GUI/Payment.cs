using BusinessObject.Models;
using BusinessObject.Shopping;
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

namespace GUI.Orders_GUI
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private List<CartItem> cartItems;
        public User currentUser;
        private decimal totalPrice;

        public Payment(List<CartItem> items, User user, decimal totalPrice)
        {
            InitializeComponent();
            cartItems = items;
            currentUser = user;
            this.totalPrice = totalPrice;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtFullName.Text = currentUser.Fullname;
            txtPhoneNumber.Text = currentUser.PhoneNumber;
            rbtnCash.Checked = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtStreet.Text))
                {
                    if (!string.IsNullOrEmpty(txtDistrict.Text))
                    {
                        if (!string.IsNullOrEmpty(txtCountry.Text))
                        {
                            if (!string.IsNullOrEmpty(txtFullName.Text))
                            {
                                if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
                                {
                                    OrderRepository orderRepository = new OrderRepository();

                                    DateOnly orderedDate = DateOnly.FromDateTime(DateTime.Now);

                                    string paymentMethod = PaymentMethod();

                                    string phoneNum = txtPhoneNumber.Text;
                                    string address = txtStreet.Text + ", " + txtDistrict.Text + ", " + txtCountry.Text;

                                    //Insert Order into Order Table
                                    orderRepository.AddOrder(currentUser.Id, orderedDate, totalPrice, paymentMethod, phoneNum, address);


                                    //Insert Order Detail into Order_Detail table
                                    OrderDetailRepository detailRepository = new OrderDetailRepository();
                                    foreach (CartItem item in cartItems)
                                    {
                                        detailRepository.AddOrderDetail(item.ProductId, item.Amount, item.Price);
                                    }
                                    MessageBox.Show("Purchase Successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    cartItems.Clear();
                                    HomePage homePage = new HomePage(cartItems, currentUser);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Empty Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Empty Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Empty Country!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty District!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Street!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at purchase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string PaymentMethod()
        {
            if (rbtnCash.Checked)
            {
                return "COD";
            }
            if (rbtnBankCard.Checked)
            {
                return "Bank Card";
            }
            if (rbtnZaloPay.Checked)
            {
                return "Zalo Pay";
            }
            if (rbtnApplePay.Checked)
            {
                return "Apple Pay";
            }
            return null;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string input = txtPhoneNumber.Text;
            string result = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            txtPhoneNumber.Text = result;
            txtPhoneNumber.Select(txtPhoneNumber.Text.Length, 0);
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            string input = txtFullName.Text;
            string result = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c) || c.Equals(' '))
                {
                    result += c;
                }
            }
            txtFullName.Text = result;
            txtFullName.Select(txtFullName.Text.Length, 0);
        }
    }
}
