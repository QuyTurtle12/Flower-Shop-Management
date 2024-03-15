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
        private List<int> stockList = new List<int>();
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
                    Cart cartForm = new Cart(cartRepository.GetCartItems(), currentUser, stockList);
                    if (cartRepository.checkCart(cartRepository.GetCartItems()))
                    {
                        cartForm.FormClosed += (s, args) => this.reload();
                        cartForm.ShowDialog();
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
            reload();
        }

        private void reload()
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
                    UnitPrice = Convert.ToDecimal(selectedRow.Cells["UnitPrice"].Value),
                    Stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value),
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
                        stockList.Add((int)selectedFlower.Stock);
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
                orderForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only customer can use this function.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string season = string.IsNullOrEmpty(cbbSeason.Text) ? null : cbbSeason.SelectedItem.ToString();
            string sort = string.IsNullOrEmpty(cbbSort.Text) ? null : cbbSort.SelectedItem.ToString();

            //One of them is not null
            if (season != null || sort != null)
            {
                //Season null and Sort not null
                if (season != null && sort == null)
                {
                    ProductRepository productRepository = new ProductRepository();
                    Dictionary<int, Flower> productList = productRepository.GetProductList();
                    dataGridView1.DataBindings.Clear();

                    List<Flower> flowers = productList.Values.ToList();
                    List<Flower> sortedFlowerList = new List<Flower>();

                    dataGridView1.Columns.Clear();
                    foreach (Flower f in flowers)
                    {
                        if (f.Season.Equals(season))
                        {
                            sortedFlowerList.Add(f);
                        }
                    }
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = sortedFlowerList;
                    dataGridView1.Columns["UnitPrice"].HeaderText = "Unit Price";
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["Stock"].Visible = true;
                    dataGridView1.Columns.Remove("OrderDetails");
                }

                //Season not null and Sort null
                if (season == null && sort != null)
                {
                    if (sort.Equals("Alphabet"))
                    {
                        ProductRepository productRepository = new ProductRepository();
                        Dictionary<int, Flower> productList = productRepository.GetProductList();
                        dataGridView1.DataBindings.Clear();

                        List<Flower> flowers = productList.Values.ToList();
                        List<Flower> sortedFlowerList = flowers.OrderBy(flower => flower.Name).ToList();

                        dataGridView1.Columns.Clear();

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = sortedFlowerList;
                        dataGridView1.Columns["UnitPrice"].HeaderText = "Unit Price";
                        dataGridView1.Columns["Id"].Visible = false;
                        dataGridView1.Columns["Stock"].Visible = true;
                        dataGridView1.Columns.Remove("OrderDetails");
                    }

                    if (sort.Equals("Ascending price"))
                    {
                        ProductRepository productRepository = new ProductRepository();
                        Dictionary<int, Flower> productList = productRepository.GetProductList();
                        dataGridView1.DataBindings.Clear();

                        List<Flower> flowers = productList.Values.ToList();
                        List<Flower> sortedFlowerList = flowers.OrderBy(flower => flower.UnitPrice).ToList();

                        dataGridView1.Columns.Clear();

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = sortedFlowerList;
                        dataGridView1.Columns["UnitPrice"].HeaderText = "Unit Price";
                        dataGridView1.Columns["Id"].Visible = false;
                        dataGridView1.Columns["Stock"].Visible = true;
                        dataGridView1.Columns.Remove("OrderDetails");
                    }

                    if (sort.Equals("Descending price"))
                    {
                        ProductRepository productRepository = new ProductRepository();
                        Dictionary<int, Flower> productList = productRepository.GetProductList();
                        dataGridView1.DataBindings.Clear();

                        List<Flower> flowers = productList.Values.ToList();
                        List<Flower> sortedFlowerList = flowers.OrderByDescending(flower => flower.UnitPrice).ToList();

                        dataGridView1.Columns.Clear();

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = sortedFlowerList;
                        dataGridView1.Columns["UnitPrice"].HeaderText = "Unit Price";
                        dataGridView1.Columns["Id"].Visible = false;
                        dataGridView1.Columns["Stock"].Visible = true;
                        dataGridView1.Columns.Remove("OrderDetails");
                    }
                }

                //Both not null
                if (season != null && sort != null)
                {
                    if (sort.Equals("Alphabet"))
                    {
                        ProductRepository productRepository = new ProductRepository();
                        Dictionary<int, Flower> productList = productRepository.GetProductList();
                        dataGridView1.DataBindings.Clear();

                        List<Flower> flowers = productList.Values.ToList();
                        List<Flower> sortedFlowerList = new List<Flower>();

                        foreach (Flower f in flowers)
                        {
                            if (f.Season.Equals(season))
                            {
                                sortedFlowerList.Add(f);
                            }
                        }
                        sortedFlowerList = sortedFlowerList.OrderBy(flower => flower.Name).ToList();

                        dataGridView1.Columns.Clear();

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = sortedFlowerList;
                        dataGridView1.Columns["UnitPrice"].HeaderText = "Unit Price";
                        dataGridView1.Columns["Id"].Visible = false;
                        dataGridView1.Columns["Stock"].Visible = true;
                        dataGridView1.Columns.Remove("OrderDetails");
                    }

                    if (sort.Equals("Ascending price"))
                    {
                        ProductRepository productRepository = new ProductRepository();
                        Dictionary<int, Flower> productList = productRepository.GetProductList();
                        dataGridView1.DataBindings.Clear();

                        List<Flower> flowers = productList.Values.ToList();
                        List<Flower> sortedFlowerList = new List<Flower>();

                        foreach (Flower f in flowers)
                        {
                            if (f.Season.Equals(season))
                            {
                                sortedFlowerList.Add(f);
                            }
                        }
                        sortedFlowerList = sortedFlowerList.OrderBy(flower => flower.UnitPrice).ToList();

                        dataGridView1.Columns.Clear();

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = sortedFlowerList;
                        dataGridView1.Columns["UnitPrice"].HeaderText = "Unit Price";
                        dataGridView1.Columns["Id"].Visible = false;
                        dataGridView1.Columns["Stock"].Visible = true;
                        dataGridView1.Columns.Remove("OrderDetails");
                    }

                    if (sort.Equals("Descending price"))
                    {
                        ProductRepository productRepository = new ProductRepository();
                        Dictionary<int, Flower> productList = productRepository.GetProductList();
                        dataGridView1.DataBindings.Clear();

                        List<Flower> flowers = productList.Values.ToList();
                        List<Flower> sortedFlowerList = new List<Flower>();

                        foreach (Flower f in flowers)
                        {
                            if (f.Season.Equals(season))
                            {
                                sortedFlowerList.Add(f);
                            }
                        }
                        sortedFlowerList = sortedFlowerList.OrderByDescending(flower => flower.UnitPrice).ToList();

                        dataGridView1.Columns.Clear();

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = sortedFlowerList;
                        dataGridView1.Columns["UnitPrice"].HeaderText = "Unit Price";
                        dataGridView1.Columns["Id"].Visible = false;
                        dataGridView1.Columns["Stock"].Visible = true;
                        dataGridView1.Columns.Remove("OrderDetails");
                    }
                }
            }
            //Both are null
            else
            {
                reload();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbbSeason.SelectedItem = null;
            cbbSort.SelectedItem = null;
            reload();
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            frmCustomerInfo customerInfoFrm = new frmCustomerInfo(currentUser);
            customerInfoFrm.ShowDialog();
        }
    }
}
