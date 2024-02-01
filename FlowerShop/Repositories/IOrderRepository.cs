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
        Dictionary<string, Order> GetOrderList(Order order);
        Order GetOrderByID(string id);
        Order GetOrderByUserId(string id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
    }
}
