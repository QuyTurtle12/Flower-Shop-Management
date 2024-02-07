using BusinessObject.Models;
using BusinessObject.Shopping;
using DataAccess.Shopping;
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
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CartRepository cartRepository = new CartRepository();
                Cart cartForm = new Cart(cartRepository.GetCartItems());
                cartForm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error opening cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            try
            {
                ProductRepository productRepository = new ProductRepository();
                Dictionary<int, Flower> productList = productRepository.GetProductList();
                dataGridView1.DataBindings.Clear();
                    
                List<Flower> flowers = productList.Values.ToList();

                dataGridView1.Columns.Clear();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = flowers;
                dataGridView1.Columns["UnitPrice"].HeaderText = "Unit Price";
                dataGridView1.Columns.Remove("Stock");
                dataGridView1.Columns.Remove("OrderDetails");

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Flower GetSelectedFlower()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                Flower selectedFlower = new Flower
                {
                    Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                    Name = selectedRow.Cells["Name"].Value.ToString(),
                    UnitPrice = Convert.ToDecimal(selectedRow.Cells["UnitPrice"].Value)
                };
                return selectedFlower;
            }
            else
            {
                return null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                CartRepository cartRepository = new CartRepository();
                Flower selectedFlower = GetSelectedFlower();
                if (selectedFlower != null)
                {
                    cartRepository.AddCartItem(new CartItem
                    {
                        ProductId = selectedFlower.Id,
                        ProductName = selectedFlower.Name,
                        Price = (decimal)selectedFlower.UnitPrice
                    });
                    MessageBox.Show("Product added to cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Please select a flower to add to the cart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product to cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
