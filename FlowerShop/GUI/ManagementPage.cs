using BusinessObject.Models;
using DataAccess;
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
    public partial class ManagementPage : Form
    {
        private User currentUser;
        private List<ProductDTO> productDTOList;
        public ManagementPage(User user)
        {
            currentUser = user;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (currentUser.Role.Equals("Admin"))
            {
                Dashboard dashboardForm = new Dashboard(productDTOList);
                dashboardForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Admin Only", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            frmOrders manageOrdersForm = new frmOrders();
            manageOrdersForm.ShowDialog(); // Use ShowDialog to open it as a modal dialog
        }

        private void ManagementPage_Load(object sender, EventArgs e)
        {
            ProductRepository productRepository = new ProductRepository();
            Dictionary<int, Flower> productList = productRepository.GetProductList();
            List<Flower> flowers = productList.Values.ToList();
            if (currentUser.Role.Equals("Admin"))
            {
                btnDashboard.Enabled = true;
                btnStaffManager.Enabled = true;
            }
            ProductDTO productDTO = new ProductDTO();
            productDTOList = productDTO.MapFlowerToDTO(flowers);
        }

        private void btnStaffManager_Click(object sender, EventArgs e)
        {
            if (currentUser.Role.Equals("Admin"))
            {
                this.Hide();
                StaffManager staffManager = new StaffManager();
                staffManager.FormClosed += (s, args) => this.Show();
                staffManager.Show();
            }
            else
            {
                MessageBox.Show("Admin Only", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage(currentUser);
            homePage.FormClosed += (s, args) => this.Show();
            homePage.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerManager customerManager = new CustomerManager();
            customerManager.FormClosed += (s, args) => this.Show();
            customerManager.Show();
        }
    }
}
