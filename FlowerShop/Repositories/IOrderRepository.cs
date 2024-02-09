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
        Dictionary<int, Order> GetOrderList(Order order);
        Dictionary<int, Order> GetOrderListByUserID(int id);
        Order GetOrderByID(int id);
        Order GetOrderByUserId(int id);
        void UpdateOrder(Order order);
        void AddOrder(int userId, DateOnly orderedDate, decimal totalPrice, string paymentMethod, string phoneNum, string address);
    }
}
