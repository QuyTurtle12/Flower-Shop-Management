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

        public Order GetOrderByID(string id) => OrderDAO.GetOrderById(id);

        public Order GetOrderByUserId(string id) => OrderDAO.GetOrderByUserId(id);

        public Dictionary<string, Order> GetOrderList(Order order) => OrderDAO.GetOrderList();

        public void UpdateOrder(Order order) => OrderDAO.UpdateOrder(order);
    }
}
