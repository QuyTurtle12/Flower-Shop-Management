using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public OrderDetail GetOrderDetailByOrderId(int OrderId) => OrderDetailDAO.GetOrderDetailByOrderId(OrderId);

        public OrderDetail GetOrderDetailByFlowerId(int FlowerId) => OrderDetailDAO.GetOrderDetailByFlowerId(FlowerId);

        public void AddOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.AddOrderDetail(orderDetail);

        public void DeleteOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.DeleteOrderDetail(orderDetail);

        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.UpdateOrderDetail(orderDetail);
    }
}
