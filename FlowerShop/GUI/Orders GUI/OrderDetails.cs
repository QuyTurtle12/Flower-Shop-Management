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
    public partial class OrderDetails : Form
    {
        private int currentOrderId;
        
        public OrderDetails()
        {
            InitializeComponent();
        }
        public OrderDetails(int orderId)
        {
            InitializeComponent();
            currentOrderId = orderId;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            txtOrderNumber.Text = currentOrderId.ToString();
            
            OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
            Dictionary<int, OrderDetail> orderDetailList = orderDetailRepository.GetOrderDetailListByOrderID(currentOrderId);
            dgvOrderDetail.DataBindings.Clear();

            List<OrderDetail> orderDetails = orderDetailList.Values.ToList();

            ProductRepository productRepository = new ProductRepository();

            foreach (OrderDetail order in orderDetails)
            {
                int rowIndex= dgvOrderDetail.Rows.Add();
                dgvOrderDetail.Rows[rowIndex].Cells["txtID"].Value = order.FlowerId;
                dgvOrderDetail.Rows[rowIndex].Cells["txtFlowerName"].Value = productRepository.GetProductById((int)order.FlowerId).Name;
                dgvOrderDetail.Rows[rowIndex].Cells["txtSeason"].Value = productRepository.GetProductById((int)order.FlowerId).Season;
                dgvOrderDetail.Rows[rowIndex].Cells["txtAmount"].Value = order.Amount;
                dgvOrderDetail.Rows[rowIndex].Cells["txtTotalPrice"].Value = order.Price;
            }
            txtNumberOfItems.Text = orderDetailList.Count.ToString();
        }
    }
}
