using BusinessObject.Models;
using BusinessObject.Shopping;
using DataAccess;
using DataAccess.Shopping;
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
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }
        public User currentUser;
        private List<CartItem> cartItems;
        private List<ProductDTO> productDTOList;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public HomePage(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        public HomePage(List<CartItem> items, User user)
        {
            InitializeComponent();
            cartItems = items;
            currentUser = user;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentUser.Role.Equals("Customer"))
                {
                    CartRepository cartRepository = new CartRepository();
                    Cart cartForm = new Cart(cartRepository.GetCartItems(), currentUser);
                    if (cartRepository.checkCart(cartRepository.GetCartItems()))
                    {
                        cartForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Cart Empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Only customer can use this function.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Stock"].Visible = true;
                dataGridView1.Columns.Remove("OrderDetails");

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                if (currentUser.Role.Equals("Admin"))
                {
                    btnDashboard.Enabled = true;
                    AddFlower.Enabled = true;
                    btnUpdate.Enabled = true;
                }
                ProductDTO productDTO = new ProductDTO();
                productDTOList = productDTO.MapFlowerToDTO(flowers);
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
                if (currentUser.Role.Equals("Customer"))
                {
                    CartRepository cartRepository = new CartRepository();
                    Flower selectedFlower = GetSelectedFlower();
                    if (selectedFlower != null)
                    {
                        cartRepository.AddCartItem(new CartItem
                        {
                            ProductId = selectedFlower.Id,
                            ProductName = selectedFlower.Name,
                            Price = (decimal)selectedFlower.UnitPrice,
                            Amount = 1
                        });
                        MessageBox.Show("Product added to cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please select a flower to add to the cart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Only customer can use this function.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product to cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            if (currentUser.Role.Equals("Customer"))
            {
                MyOrders orderForm = new MyOrders(currentUser);
                orderForm.Show();
            }
            else
            {
                MessageBox.Show("Only customer can use this function.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard(productDTOList);
            dashboardForm.Show();
        }

        private void btnAddFlower_Click(object sender, EventArgs e)
        {
            if (currentUser.Role.Equals("Admin"))
            {
                AddFlowerForm addFlowerForm = new AddFlowerForm();
                addFlowerForm.Show();
            }
            else
            {
                MessageBox.Show("Only admin can use this function.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentUser.Role.Equals("Admin"))
            {
                //Update Flower with the flower selected in the datagridview
                Flower selectedFlower = GetSelectedFlower();
                if (selectedFlower != null)
                {
                    UpdateFlower updateFlowerForm = new UpdateFlower(selectedFlower);
                    updateFlowerForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a flower to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Only admin can use this function.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
