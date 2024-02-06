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

        public static Dictionary<int, Order> GetOrderList()
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
        public static Order GetOrderById(int id)
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
        public static Order GetOrderByUserId(int id)
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
        public static void AddOrder(Order order) {
            //Create an order when a user buy products from cart
        }
        public static void UpdateOrder(Order order) {
            //Update Order Status
        }
    }
}
