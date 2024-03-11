using BusinessObject.Models;
using BusinessObject.Shopping;
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
    public partial class Cart : Form
    {
        private List<CartItem> cartItems;
        public User currentUser;
        private decimal totalPrice;
        private List<int> stockList;
        public Cart()
        {
            InitializeComponent();
        }

        public Cart(List<CartItem> items)
        {
            InitializeComponent();
            cartItems = items;
        }

        public Cart(List<CartItem> items, User user, List<int> stockList)
        {
            InitializeComponent();
            cartItems = items;
            currentUser = user;
            this.stockList = stockList;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            List<CartItem> items = cartItems.ToList();
            dgvCart.DataBindings.Clear();
            int productLoadedCount = 0;
            foreach (CartItem item in items)
            {
                int rowIndex = dgvCart.Rows.Add();
                dgvCart.Rows[rowIndex].Cells["txtFlowerId"].Value = item.ProductId;
                dgvCart.Rows[rowIndex].Cells["txtFlowerName"].Value = item.ProductName;
                dgvCart.Rows[rowIndex].Cells["txtPrice"].Value = item.Price * Convert.ToDecimal(item.Amount);
                int unitInStock = Convert.ToInt32(stockList[productLoadedCount]);
                if (item.ProductId != null)
                {
                    // Add ComboBox value only for rows with non-null product ID
                    DataGridViewComboBoxCell amountCell = (DataGridViewComboBoxCell)dgvCart.Rows[rowIndex].Cells["amount"];
                    amountCell.Items.Clear();
                    amountCell.Items.AddRange(Enumerable.Range(1, unitInStock).Select(i => i.ToString()).ToArray());
                    amountCell.Value = item.Amount.ToString();
                }
                productLoadedCount++;
            }
            TotalPriceCal();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private Flower GetSelectedFlower()
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvCart.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dgvCart.Rows[selectedRowIndex];

                Flower selectedFlower = new Flower
                {
                    Id = Convert.ToInt32(selectedRow.Cells["txtFlowerId"].Value),
                    Name = selectedRow.Cells["txtFlowerName"].Value.ToString(),
                    UnitPrice = Convert.ToDecimal(selectedRow.Cells["txtPrice"].Value)
                };
                return selectedFlower;
            }
            else
            {
                return null;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                CartRepository cartRepository = new CartRepository();
                Flower selectedFlower = GetSelectedFlower();
                if (selectedFlower != null)
                {
                    if (cartRepository.RemoveCartItem(new CartItem
                    {
                        ProductId = selectedFlower.Id,
                        ProductName = selectedFlower.Name,
                        Price = (decimal)selectedFlower.UnitPrice
                    }))
                    {
                        ReloadCartItem(); //Reload the cart after remove item
                        MessageBox.Show("Product removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Product not found in the cart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    MessageBox.Show("Please select a flower to remove from the cart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error removing product out of the cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadCartItem()
        {
            List<CartItem> items = cartItems.ToList();
            dgvCart.Rows.Clear();
            int productLoadedCount = 0;
            foreach (CartItem item in items)
            {
                int rowIndex = dgvCart.Rows.Add();
                dgvCart.Rows[rowIndex].Cells["txtFlowerId"].Value = item.ProductId;
                dgvCart.Rows[rowIndex].Cells["txtFlowerName"].Value = item.ProductName;
                dgvCart.Rows[rowIndex].Cells["txtPrice"].Value = item.Price * Convert.ToDecimal(item.Amount);
                int unitInStock = Convert.ToInt32(stockList[productLoadedCount]);

                if (item.ProductId != null)
                {
                    // Add ComboBox value only for rows with non-null product ID
                    DataGridViewComboBoxCell amountCell = (DataGridViewComboBoxCell)dgvCart.Rows[rowIndex].Cells["amount"];
                    amountCell.Items.Clear();
                    amountCell.Items.AddRange(Enumerable.Range(1, unitInStock).Select(i => i.ToString()).ToArray());
                    amountCell.Value = item.Amount.ToString();
                }
                productLoadedCount++;
            }
            TotalPriceCal();
        }

        private void dgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    // Check if the row is not null and is not a new row
                    if (!row.IsNewRow && row.Cells["amount"] != null)
                    {
                        DataGridViewComboBoxCell amountCell = row.Cells["amount"] as DataGridViewComboBoxCell;
                        if (amountCell != null && amountCell.Value != null)
                        {
                            int amount = Convert.ToInt32(amountCell.Value);

                            // Update the corresponding CartItem in the cartItems list
                            int productId = Convert.ToInt32(row.Cells["txtFlowerId"].Value);
                            CartItem product = cartItems.FirstOrDefault(item => item.ProductId == productId);
                            if (product != null)
                            {
                                product.Amount = amount;
                            }
                        }
                    }
                }
                ReloadCartItem();
                MessageBox.Show("Cart items updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating cart items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalPriceCal()
        {
            try
            {
                decimal totalPrice = 0;
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (!row.IsNewRow && row.Cells["txtPrice"] != null)
                    {
                        DataGridViewTextBoxCell priceCell = row.Cells["txtPrice"] as DataGridViewTextBoxCell;
                        if (priceCell != null && priceCell.Value != null)
                        {
                            decimal price = Convert.ToDecimal(priceCell.Value);
                            totalPrice += price;
                        }
                    }
                }
                this.totalPrice = totalPrice;
                lbPrice.Text = totalPrice.ToString() + "$";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                CartRepository cartRepository = new CartRepository();
                Payment paymentForm = new Payment(cartRepository.GetCartItems(), currentUser, totalPrice);
                paymentForm.FormClosed += (s, args) => this.Close();
                paymentForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening payment form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
