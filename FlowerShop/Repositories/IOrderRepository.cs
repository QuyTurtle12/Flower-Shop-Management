using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        Dictionary<int, Order> GetOrderList();
        Dictionary<int, Order> GetOrderListByUserID(int id);
        Order GetOrderByID(int id);
        Order GetOrderByUserId(int id);
        Dictionary<int, Order> GetOrdersOneMonthBefore(Dictionary<int, Order> orders);
        Dictionary<int, Order> GetOrdersThreeMonthsBefore(Dictionary<int, Order> orders);
        Dictionary<int, Order> GetOrdersSixMonthsBefore(Dictionary<int, Order> orders);
        Dictionary<int, Order> GetOrdersOneYearBefore(Dictionary<int, Order> orders);
        void UpdateOrder(Order order);
        void AddOrder(int userId, DateOnly orderedDate, decimal totalPrice, string paymentMethod, string phoneNum, string address);
        List<Order> GetOrdersByStatus(string status);
    }
}
