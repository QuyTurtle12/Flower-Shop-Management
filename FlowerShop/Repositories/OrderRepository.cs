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

        public Dictionary<int, Order> GetOrderList(Order order) => OrderDAO.Instance.GetOrderList();

        public Dictionary<int, Order> GetOrderListByUserID(int id) => OrderDAO.Instance.GetOrderListByUserID(id);

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
