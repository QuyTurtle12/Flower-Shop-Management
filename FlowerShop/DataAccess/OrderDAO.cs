using BusinessObject.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        //Singleton Pattern
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public Dictionary<int, Order> GetOrderList()
        {
            Dictionary<int, Order> listOrder = new Dictionary<int, Order>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    listOrder = context.Orders.ToDictionary(Order => Order.Id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrder;
        }

        //Get Order by Order ID
        public Order GetOrderById(int id)
        {
            Order order = null;
            try
            {
                using var context = new FlowerShopContext();
                order = context.Orders.SingleOrDefault(o => o.Id == id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        //Get Order by User ID
        public Order GetOrderByUserId(int id)
        {
            Order order = null;
            try
            {
                using var context = new FlowerShopContext();
                order = context.Orders.SingleOrDefault(o => o.UserId == id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }
        public void AddOrder(Order order) {
            //Create an order when a user buy products from cart
        }
        public void UpdateOrder(Order order) {
            //Update Order Status
        }
    }
}
