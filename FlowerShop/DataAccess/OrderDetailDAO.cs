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

        //View Order detail by Order ID
        public static OrderDetail GetOrderDetailByOrderId(string OrderId)
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
        public static OrderDetail GetOrderDetailByFlowerId(string FlowerId)
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

        public static void AddOrderDetail(OrderDetail orderDetail) { }
        public static void DeleteOrderDetail(OrderDetail orderDetail) { }
        public static void UpdateOrderDetail(OrderDetail orderDetail) { }
    }
}
