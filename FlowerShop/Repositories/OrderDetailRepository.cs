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
        public OrderDetail GetOrderDetailByOrderId(int OrderId) => OrderDetailDAO.Instance.GetOrderDetailByOrderId(OrderId);

        public OrderDetail GetOrderDetailByFlowerId(int FlowerId) => OrderDetailDAO.Instance.GetOrderDetailByFlowerId(FlowerId);

        public void DeleteOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.DeleteOrderDetail(orderDetail);

        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);

        public Dictionary<int, OrderDetail> GetOrderDetailListByOrderID(int orderId) => OrderDetailDAO.Instance.GetOrderDetailListByOrderID(orderId);

        public void AddOrderDetail(int flowerId, int amount, decimal price) => OrderDetailDAO.Instance.AddOrderDetail(flowerId, amount, price);

        public Dictionary<int, OrderDetail> GetOrderDetailListByFlowerID(int flowerId) => OrderDetailDAO.Instance.GetOrderDetailListByFlowerID(flowerId);
    }
}
