using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(int userId, DateOnly orderedDate, decimal totalPrice, string paymentMethod, string phoneNum, string address) => OrderDAO.Instance.AddOrder(userId, orderedDate, totalPrice, paymentMethod, phoneNum, address);

        public Order GetOrderByID(int id) => OrderDAO.Instance.GetOrderById(id);

        public Order GetOrderByUserId(int id) => OrderDAO.Instance.GetOrderByUserId(id);

        public Dictionary<int, Order> GetOrderList() => OrderDAO.Instance.GetOrderList();

        public Dictionary<int, Order> GetOrderListByUserID(int id) => OrderDAO.Instance.GetOrderListByUserID(id);

        public Dictionary<int, Order> GetOrdersOneMonthBefore(Dictionary<int, Order> orders) => OrderDAO.Instance.GetOrdersOneMonthBefore(orders);

        public Dictionary<int, Order> GetOrdersThreeMonthsBefore(Dictionary<int, Order> orders) => OrderDAO.Instance.GetOrdersThreeMonthsBefore(orders);

        public Dictionary<int, Order> GetOrdersSixMonthsBefore(Dictionary<int, Order> orders) => OrderDAO.Instance.GetOrdersSixMonthsBefore(orders);

        public Dictionary<int, Order> GetOrdersOneYearBefore(Dictionary<int, Order> orders) => OrderDAO.Instance.GetOrdersOneYearBefore(orders);

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
        public List<Order> GetOrdersByStatus(string status) => OrderDAO.Instance.GetOrdersByStatus(status);
    }
}
