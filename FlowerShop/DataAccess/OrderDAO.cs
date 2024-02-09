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

        //Get order list base on user id
        public Dictionary<int, Order> GetOrderListByUserID(int id)
        {
            Dictionary<int, Order> listOrder = new Dictionary<int, Order>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    // Query orders associated with the specified user ID
                    var orders = context.Orders.Where(order => order.UserId == id).ToList();


                    listOrder = orders.ToDictionary(order => order.Id);
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

        private int orderIdGeneration()
        {
            using (var context = new FlowerShopContext())
            {
                Random rnd = new Random();
                int orderId;
                do
                {
                    orderId = rnd.Next(1, 1000); // Generate a random integer between 1 and 999
                } while (context.Orders.Any(o => o.Id == orderId)); // Check if the orderId already exists
                return orderId;
            }
        }

        public void AddOrder(int userId, DateOnly orderedDate, decimal totalPrice, string paymentMethod, string phoneNum, string address)
        {
            //Create an order when a user buy products from cart
            int orderId = orderIdGeneration();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    Order order = new Order
                    {
                        Id = orderId,
                        UserId = userId,
                        OrderedDate = orderedDate,
                        TotalPrice = totalPrice,
                        PaymentMethod = paymentMethod,
                        Phone = phoneNum,
                        Address = address,
                        Status = "Unprocessed"
                    };
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                OrderDetailDAO.Instance.GetOrderIdFromOrderDAO(orderId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding order: " + ex.Message);
            }
        }

        public void UpdateOrder(Order order)
        {
            //Update Order Status
        }
    }
}


