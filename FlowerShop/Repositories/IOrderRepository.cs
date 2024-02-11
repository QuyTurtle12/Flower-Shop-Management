using BusinessObject.Models;
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
        Order GetOrderByID(int id);
        Order GetOrderByUserId(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
    }
}
