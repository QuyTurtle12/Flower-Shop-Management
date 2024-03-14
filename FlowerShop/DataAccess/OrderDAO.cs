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

        public Dictionary<int, Order> GetOrdersOneMonthBefore(Dictionary<int, Order> orders)
        {
            Dictionary<int, Order> listOrder = new Dictionary<int, Order>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    DateOnly oneMonthAgo = DateOnly.FromDateTime(DateTime.Now.AddMonths(-1));

                    listOrder = orders
                    .Where(kvp => kvp.Value.OrderedDate >= oneMonthAgo)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrder;
        }

        public Dictionary<int, Order> GetOrdersThreeMonthsBefore(Dictionary<int, Order> orders)
        {
            Dictionary<int, Order> listOrder = new Dictionary<int, Order>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    DateOnly threeMonthAgo = DateOnly.FromDateTime(DateTime.Now.AddMonths(-3));

                    listOrder = orders
                    .Where(kvp => kvp.Value.OrderedDate >= threeMonthAgo)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrder;
        }

        public Dictionary<int, Order> GetOrdersSixMonthsBefore(Dictionary<int, Order> orders)
        {
            Dictionary<int, Order> listOrder = new Dictionary<int, Order>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    DateOnly sixMonthAgo = DateOnly.FromDateTime(DateTime.Now.AddMonths(-6));

                    listOrder = orders
                    .Where(kvp => kvp.Value.OrderedDate >= sixMonthAgo)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrder;
        }

        public Dictionary<int, Order> GetOrdersOneYearBefore(Dictionary<int, Order> orders)
        {
            Dictionary<int, Order> listOrder = new Dictionary<int, Order>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    DateOnly oneYearAgo = DateOnly.FromDateTime(DateTime.Now.AddMonths(-12));

                    listOrder = orders
                    .Where(kvp => kvp.Value.OrderedDate >= oneYearAgo)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listOrder;
        }

        private int orderIdGeneration()
        {
            using (var context = new FlowerShopContext())
            {
                int lastOrderId = context.Orders.Max(c => c.Id); // Retrieve the last used OrderId
                return lastOrderId + 1; // Increment it by 1 to generate a new OrderId
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

        public void UpdateOrderStatus(int orderId, string newStatus)
        {
            using var context = new FlowerShopContext();
            var order = context.Orders.SingleOrDefault(o => o.Id == orderId);
            if (order == null) throw new Exception("Order not found.");

            if (order.Status == "Canceled")
            {
                throw new Exception("Cannot update a canceled order.");
            }

            var orderDetails = OrderDetailDAO.Instance.GetOrderDetailListByOrderID(orderId).Values.ToList();

            try
            {
                // Handle stock adjustment for processing orders
                if (newStatus == "Processing" && order.Status != "Processing")
                {
                    foreach (var detail in orderDetails)
                    {
                        ProductDAO.Instance.UpdateStock(detail.FlowerId.Value, -detail.Amount.Value); // Attempt to subtract stock
                    }
                }
                // Handle stock adjustment for orders failing delivery
                else if (order.Status == "Processing" && newStatus == "Delivering Failed")
                {
                    foreach (var detail in orderDetails)
                    {
                        ProductDAO.Instance.UpdateStock(detail.FlowerId.Value, detail.Amount.Value); // Restock
                    }
                }
            }
            catch (Exception ex)
            {
                // If any stock adjustment fails, don't update the order status and inform the caller
                throw new Exception(ex.Message);
            }

            // Proceed with status update only if stock adjustments succeeded
            order.Status = newStatus;

            if (newStatus == "Finished")
            {
                order.ShippedDate = DateOnly.FromDateTime(DateTime.Now);
            }

            context.SaveChanges();
        }


        public List<Order> GetOrdersByStatus(string status)
        {
            using var context = new FlowerShopContext();
            var filteredOrders = context.Orders.Where(order => order.Status.Equals(status, StringComparison.OrdinalIgnoreCase)).ToList();
            return filteredOrders;
        }

        public void UpdateOrder(Order order) => throw new NotImplementedException();

    }
}


