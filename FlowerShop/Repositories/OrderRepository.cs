using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    internal class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order) => OrderDAO.AddOrder(order);

        public Order GetOrderByID(int id) => OrderDAO.GetOrderById(id);

        public Order GetOrderByUserId(int id) => OrderDAO.GetOrderByUserId(id);

        public Dictionary<int, Order> GetOrderList(Order order) => OrderDAO.GetOrderList();

        public void UpdateOrder(Order order) => OrderDAO.UpdateOrder(order);
    }
}
