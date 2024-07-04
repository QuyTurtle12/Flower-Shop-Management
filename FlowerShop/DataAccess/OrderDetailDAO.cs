using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        //Singleton Pattern
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public Dictionary<int, OrderDetail> GetOrderDetailListByOrderID(int id)
        {
            Dictionary<int, OrderDetail> listOrder = new Dictionary<int, OrderDetail>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    var orders = context.OrderDetails.Where(order => order.OrderId == id).ToList();

                    listOrder = orders.ToDictionary(order => order.OrderDetailId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrder;
        }

        //View Order detail by Order ID
        public OrderDetail GetOrderDetailByOrderId(int OrderId)
        {
            OrderDetail orderDetail = null;
            try
            {
                using var context = new FlowerShopContext();
                orderDetail = context.OrderDetails.SingleOrDefault(od => od.OrderId == OrderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetail;
        }

        //View Order detail by Flower ID
        //Useful for Flower Dashboard
        public Dictionary<int, OrderDetail> GetOrderDetailListByFlowerID(int id)
        {
            Dictionary<int, OrderDetail> listOrder = new Dictionary<int, OrderDetail>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    var flowers = context.OrderDetails.Where(flower => flower.FlowerId == id).ToList();
                    listOrder = flowers.ToDictionary(flower => flower.OrderDetailId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrder;
        }

        public OrderDetail GetOrderDetailByFlowerId(int FlowerId)
        {
            OrderDetail orderDetail = null;
            try
            {
                using var context = new FlowerShopContext();
                orderDetail = context.OrderDetails.SingleOrDefault(od => od.FlowerId == FlowerId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetail;
        }

        private int orderId;
        public void GetOrderIdFromOrderDAO(int orderId)
        {
            this.orderId = orderId;
        }

        public void AddOrderDetail(int flowerId, int amount, decimal price) {
            try
            {
                using (var context = new FlowerShopContext())
                {
                    OrderDetail detail = new OrderDetail
                    {
                        OrderId = orderId,
                        FlowerId = flowerId,
                        Amount = amount,
                        Price = price
                    };
                    context.OrderDetails.Add(detail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error at adding order detail: " + ex.Message);
            }
        }
        public void DeleteOrderDetail(OrderDetail orderDetail) { }
        public void UpdateOrderDetail(OrderDetail orderDetail) { }
    }
}
