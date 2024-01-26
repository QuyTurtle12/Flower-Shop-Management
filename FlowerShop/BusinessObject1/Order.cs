using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    internal class Order
    {
        public string OrderID {  get; set; }
        public required string UserID { get; set; }
        public double Total { get; set; }
        public string PaymentMethod {  get; set; }
        public DateTime OrderedDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string Status { get; set; } //(Unprocessed/Canceled/Processing/ Delivering/ Finished)

        public Order(string orderID, string userID, double total, string paymentMethod, DateTime orderedDate, DateTime shippedDate, string status)
        {
            OrderID = orderID;
            UserID = userID;
            Total = total;
            PaymentMethod = paymentMethod;
            OrderedDate = orderedDate;
            ShippedDate = shippedDate;
            Status = status;
        }

        public Order() { }
        public override string ToString()
        {
            return $"OrderID{OrderID}|UserID:{UserID}|Ordered Date:{OrderedDate}|Shipped Date: {ShippedDate}|Payment Method:{PaymentMethod}|Total Price:{Total}|Status:{Status}";
        }
    }
}
