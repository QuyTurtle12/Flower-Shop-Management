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
    public partial class Dashboard : Form
    {
        public List<ProductDTO> productList;
        public List<Order> orderList;
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(List<ProductDTO> products)
        {
            InitializeComponent();
            productList = products;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            ProductSaleCount();
            productList = ProductSort(productList);

            for (int i = 0; i < Math.Min(5, productList.Count); i++)
            {
                var product = productList[i];
                TextBox txtRank = Controls.Find("txtRank" + (i + 1), true).FirstOrDefault() as TextBox;
                TextBox txtSaleRank = Controls.Find("txtSaleRank" + (i + 1), true).FirstOrDefault() as TextBox;

                if (txtRank != null && txtSaleRank != null)
                {
                    txtRank.Text = product.Name;
                    txtSaleRank.Text = product.SaleAmount.ToString();
                }
            }
        }

        //Last Month
        private void ProductSaleCount()
        {
            int saleAmount;
            OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
            OrderRepository orderRepository = new OrderRepository();

            Dictionary<int, Order> orders = orderRepository.GetOrderList();

            Dictionary<int, OrderDetail> orderDetails = null;
            List<OrderDetail> orderDetailList = null;

            //Filter by 1 Month
            if (cbbFilter.SelectedItem != null && cbbFilter.SelectedItem.ToString().Equals("1 Month"))
            {
                orders = orderRepository.GetOrdersOneMonthBefore(orders);
                List<Order> orderList = orders.Values.ToList();
                foreach (Order order in orderList)
            {
                orderDetails = orderDetailRepository.GetOrderDetailListByOrderID(order.Id);
                orderDetailList = orderDetails.Values.ToList();
                foreach (ProductDTO productDTO in productList)
                {
                    saleAmount = 0;
                    foreach (OrderDetail orderDetail in orderDetailList)
                    {
                        if (productDTO.Id == orderDetail.FlowerId)
                        {
                            saleAmount += (int)orderDetail.Amount;
                        }
                    }
                    productDTO.SaleAmount += saleAmount;
                }
            }
            }

            //Filter by 3 Months
            if (cbbFilter.SelectedItem != null && cbbFilter.SelectedItem.ToString().Equals("3 Months"))
            {
                orders = orderRepository.GetOrdersThreeMonthsBefore(orders);
                List<Order> orderList = orders.Values.ToList();
                foreach (Order order in orderList)
                {
                    orderDetails = orderDetailRepository.GetOrderDetailListByOrderID(order.Id);
                    orderDetailList = orderDetails.Values.ToList();
                    foreach (ProductDTO productDTO in productList)
                    {
                        saleAmount = 0;
                        foreach (OrderDetail orderDetail in orderDetailList)
                        {
                            if (productDTO.Id == orderDetail.FlowerId)
                            {
                                saleAmount += (int)orderDetail.Amount;
                            }
                        }
                        productDTO.SaleAmount += saleAmount;
                    }
                }
            }

            //Filter by 6 Months
            if (cbbFilter.SelectedItem != null && cbbFilter.SelectedItem.ToString().Equals("6 Months"))
            {
                orders = orderRepository.GetOrdersSixMonthsBefore(orders);
                List<Order> orderList = orders.Values.ToList();
                foreach (Order order in orderList)
                {
                    orderDetails = orderDetailRepository.GetOrderDetailListByOrderID(order.Id);
                    orderDetailList = orderDetails.Values.ToList();
                    foreach (ProductDTO productDTO in productList)
                    {
                        saleAmount = 0;
                        foreach (OrderDetail orderDetail in orderDetailList)
                        {
                            if (productDTO.Id == orderDetail.FlowerId)
                            {
                                saleAmount += (int)orderDetail.Amount;
                            }
                        }
                        productDTO.SaleAmount += saleAmount;
                    }
                }
            }

            //Filter by 1 Year
            if (cbbFilter.SelectedItem != null && cbbFilter.SelectedItem.ToString().Equals("1 Year"))
            {
                orders = orderRepository.GetOrdersOneYearBefore(orders);
                List<Order> orderList = orders.Values.ToList();
                foreach (Order order in orderList)
                {
                    orderDetails = orderDetailRepository.GetOrderDetailListByOrderID(order.Id);
                    orderDetailList = orderDetails.Values.ToList();
                    foreach (ProductDTO productDTO in productList)
                    {
                        saleAmount = 0;
                        foreach (OrderDetail orderDetail in orderDetailList)
                        {
                            if (productDTO.Id == orderDetail.FlowerId)
                            {
                                saleAmount += (int)orderDetail.Amount;
                            }
                        }
                        productDTO.SaleAmount += saleAmount;
                    }
                }
            }
        }

        //Sort descending base on sale amount
        private List<ProductDTO> ProductSort(List<ProductDTO> products)
        {
            List<ProductDTO> sortedList = products.OrderByDescending(p => p.SaleAmount).ToList();
            return sortedList;
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reset sale amount
            foreach (ProductDTO productDTO in productList)
            {
                productDTO.SaleAmount = 0;
            }

            ProductSaleCount();
            productList = ProductSort(productList);

            for (int i = 0; i < Math.Min(5, productList.Count); i++)
            {
                var product = productList[i];
                TextBox txtRank = Controls.Find("txtRank" + (i + 1), true).FirstOrDefault() as TextBox;
                TextBox txtSaleRank = Controls.Find("txtSaleRank" + (i + 1), true).FirstOrDefault() as TextBox;

                if (txtRank != null && txtSaleRank != null)
                {
                    txtRank.Text = product.Name;
                    txtSaleRank.Text = product.SaleAmount.ToString();
                }
            }
        }
    }
}
