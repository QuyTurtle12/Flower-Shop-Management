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

namespace GUI
{
    public partial class Cart : Form
    {
        private List<CartItem> cartItems;
        public Cart()
        {
            InitializeComponent();
        }

        public Cart(List<CartItem> items)
        {
            InitializeComponent();
            cartItems = items;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            List<CartItem> items = cartItems.ToList();
            dgvCart.DataBindings.Clear();
            foreach (CartItem item in items)
            {
                int rowIndex = dgvCart.Rows.Add();
                dgvCart.Rows[rowIndex].Cells["txtFlowerId"].Value = item.ProductId;
                dgvCart.Rows[rowIndex].Cells["txtFlowerName"].Value = item.ProductName;
                dgvCart.Rows[rowIndex].Cells["txtPrice"].Value = item.Price;

            }

            DataGridViewColumn column = dgvCart.Columns["amount"];
            DataGridViewComboBoxColumn amountColumn = (DataGridViewComboBoxColumn)column;
            amountColumn.Items.Clear();
            amountColumn.Items.AddRange(Enumerable.Range(1, 100).Select(i => i.ToString()).ToArray());
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Set the default value for the "amount" column
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                DataGridViewComboBoxCell comboBoxCell = row.Cells["amount"] as DataGridViewComboBoxCell;
                if (comboBoxCell != null)
                {
                    comboBoxCell.Value = comboBoxCell.Items[0]; // Set default value to the first item in the ComboBox
                }
            }
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
                    } else
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
            foreach (CartItem item in items)
            {
                int rowIndex = dgvCart.Rows.Add();
                dgvCart.Rows[rowIndex].Cells["txtFlowerId"].Value = item.ProductId;
                dgvCart.Rows[rowIndex].Cells["txtFlowerName"].Value = item.ProductName;
                dgvCart.Rows[rowIndex].Cells["txtPrice"].Value = item.Price;

            }

            DataGridViewColumn column = dgvCart.Columns["amount"];
            DataGridViewComboBoxColumn amountColumn = (DataGridViewComboBoxColumn)column;
            amountColumn.Items.Clear();
            amountColumn.Items.AddRange(Enumerable.Range(1, 100).Select(i => i.ToString()).ToArray());
        }
    }
}
