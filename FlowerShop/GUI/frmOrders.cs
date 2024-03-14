using BusinessObject.Models;
using DataAccess;
using GUI.Orders_GUI;
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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadAllOrders();
            statusFilterComboBox.SelectedIndex = 0;
        }

        private void LoadAllOrders()
        {
            var orders = OrderDAO.Instance.GetOrderList().Values.ToList();
            ordersDataGridView.DataSource = orders;
            AdjustDataGridViewColumns();
        }

        private void AdjustDataGridViewColumns()
        {
            // Assuming ordersDataGridView is already populated with data including the UserId column

            // Hide the columns you do not want to display
            ordersDataGridView.Columns["OrderDetails"].Visible = false;
            ordersDataGridView.Columns["User"].Visible = false;
            ordersDataGridView.Columns["UserId"].Visible = false; // Keep it hidden but available for data retrieval

            // Add a Buyer column if it does not exist
            if (!ordersDataGridView.Columns.Contains("Buyer"))
            {
                DataGridViewTextBoxColumn buyerColumn = new DataGridViewTextBoxColumn();
                buyerColumn.Name = "Buyer";
                buyerColumn.HeaderText = "Buyer";
                ordersDataGridView.Columns.Add(buyerColumn);
            }

            PopulateBuyerColumn(); // Populate the Buyer column with User's Fullname
        }
        private void PopulateBuyerColumn()
        {
            UserRepository userRepository = new UserRepository();

            foreach (DataGridViewRow row in ordersDataGridView.Rows)
            {
                if (row.Cells["UserId"].Value != null)
                {
                    int userId = Convert.ToInt32(row.Cells["UserId"].Value);
                    User user = userRepository.GetUserById(userId);
                    if (user != null)
                    {
                        row.Cells["Buyer"].Value = user.Fullname; // Assuming Fullname is the property you want to display
                    }
                }
            }
        }


        private void filterButton_Click(object sender, EventArgs e)
        {
            if (statusFilterComboBox.SelectedItem.ToString() == "All")
            {
                LoadAllOrders();
            }
            else
            {
                var filteredOrders = OrderDAO.Instance.GetOrdersByStatus(statusFilterComboBox.SelectedItem.ToString());
                ordersDataGridView.DataSource = filteredOrders;
            }
        }
        private void PopulateUpdateStatusComboBox(string currentStatus)
        {
            updateStatusComboBox.Items.Clear(); // Clear existing items

            // Based on the current status, add the next possible statuses
            switch (currentStatus)
            {
                case "Unprocessed":
                    updateStatusComboBox.Items.Add("Canceled");
                    updateStatusComboBox.Items.Add("Processing");
                    break;
                case "Processing":
                    updateStatusComboBox.Items.Add("Delivering");
                    break;
                case "Delivering":
                    updateStatusComboBox.Items.Add("Finished");
                    updateStatusComboBox.Items.Add("Delivering Failed");
                    break;
                case "Delivering Failed":
                    updateStatusComboBox.Items.Add("Processing");
                    updateStatusComboBox.Items.Add("Canceled");
                    break;
                    // Add more cases as necessary
            }

            if (updateStatusComboBox.Items.Count > 0)
                updateStatusComboBox.SelectedIndex = 0; // Select the first item by default
        }

        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = ordersDataGridView.CurrentRow;
            if (selectedRow != null)
            {
                string currentStatus = selectedRow.Cells["status"].Value.ToString(); // Replace "StatusColumnName" with the actual name of the column
                PopulateUpdateStatusComboBox(currentStatus);
            }
        }


        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            var selectedRow = ordersDataGridView.CurrentRow;
            if (selectedRow != null && updateStatusComboBox.SelectedItem != null)
            {
                int orderId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string newStatus = updateStatusComboBox.SelectedItem.ToString();

                try
                {
                    OrderDAO.Instance.UpdateOrderStatus(orderId, newStatus);
                    MessageBox.Show("Order status updated successfully.");
                    LoadAllOrders(); // Refresh the DataGridView to reflect the updated status
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update order status: {ex.Message}");
                }
            }
        }

        private void ordersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(ordersDataGridView.Rows[e.RowIndex].Cells["id"].Value);
                OrderDetails orderDetailsForm = new OrderDetails(orderId);
                orderDetailsForm.ShowDialog(); 
            }

        }


    }
}
