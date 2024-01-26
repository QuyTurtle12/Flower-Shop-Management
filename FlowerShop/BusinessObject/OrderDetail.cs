using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    internal class OrderDetail
    {
        public required string OrderID {  get; set; }
        public required string FlowerID { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; } //Unit price x Amount

        public OrderDetail(string orderID, string flowerID, int amount, double price)
        {
            OrderID = orderID;
            FlowerID = flowerID;
            Amount = amount;
            Price = price;
        }

        public OrderDetail() { }

        public override string ToString()
        {
            return $"OrderID:{OrderID}|FlowerID:{FlowerID}|Amount:{Amount}|Price:{Price}";
        }
    }
}
