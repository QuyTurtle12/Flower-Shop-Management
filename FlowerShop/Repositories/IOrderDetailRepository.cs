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
        OrderDetail GetOrderDetailByOrderId(string OrderId);
        void DeleteOrderDetail(OrderDetail orderDetail);
        void AddOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        OrderDetail GetOrderDetailByFlowerId(string FlowerId);
    }
}
