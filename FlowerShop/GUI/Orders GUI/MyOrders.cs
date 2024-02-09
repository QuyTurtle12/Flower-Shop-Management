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

namespace GUI.Orders_GUI
{
    public partial class MyOrders : Form
    {
        public MyOrders()
        {
            InitializeComponent();
        }
        public User currentUser;
        public MyOrders(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a link cell and is in the "Order" column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvOrder.Columns[e.ColumnIndex] is DataGridViewLinkColumn && dgvOrder.Columns[e.ColumnIndex].Name == "txtOrderId")
            {
                // Extract the order ID from the clicked cell
                int orderId = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells["txtOrderId"].Value);

                // Open the Order Detail Form with the order ID
                OrderDetails orderDetailForm = new OrderDetails(orderId);
                orderDetailForm.Show();
            }
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            txtClient.Text = currentUser.Fullname;
            txtPhoneNumber.Text = currentUser.PhoneNumber;
            txtEmail.Text = currentUser.Email;
            txtClientID.Text = Convert.ToString(currentUser.Id);

            OrderRepository orderRepository = new OrderRepository();
            Dictionary<int, Order> orderList = orderRepository.GetOrderListByUserID(currentUser.Id);
            dgvOrder.DataBindings.Clear();

            List<Order> orders = orderList.Values.ToList();
            foreach (Order order in orders)
            {
                int rowIndex = dgvOrder.Rows.Add();
                dgvOrder.Rows[rowIndex].Cells["txtOrderId"].Value = order.Id;
                dgvOrder.Rows[rowIndex].Cells["txtTotalPrice"].Value = order.TotalPrice;
                dgvOrder.Rows[rowIndex].Cells["txtPaymentMethod"].Value = order.PaymentMethod;
                dgvOrder.Rows[rowIndex].Cells["PhoneNumber"].Value = order.Phone;
                dgvOrder.Rows[rowIndex].Cells["txtAddress"].Value = order.Address;
                dgvOrder.Rows[rowIndex].Cells["txtStatus"].Value = order.Status;
                dgvOrder.Rows[rowIndex].Cells["txtOrderDate"].Value = order.OrderedDate;
                dgvOrder.Rows[rowIndex].Cells["txtShippedDate"].Value = order.ShippedDate;

                foreach (DataGridViewColumn column in dgvOrder.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }
    }
}
