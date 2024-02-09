using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        Dictionary<int, OrderDetail> GetOrderDetailListByOrderID(int orderId);
        OrderDetail GetOrderDetailByOrderId(int OrderId);
        void DeleteOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        OrderDetail GetOrderDetailByFlowerId(int FlowerId);
        void AddOrderDetail(int flowerId, int amount, decimal price);
    }
}
