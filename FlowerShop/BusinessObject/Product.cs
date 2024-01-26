using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    internal class Product
    {
        public string FlowerId { get; set; }
        public string FlowerName { get; set; }
        public string Season {  get; set; }
        public double Price { get; set; } //Unit price
        public string FlowerDesc { get; set; } //Flower Description
        public int Stock {  get; set; }

        public Product(string flowerId, string flowerName, string season, double price, string flowerDesc, int stock)
        {
            FlowerId = flowerId;
            FlowerName = flowerName;
            Season = season;
            Price = price;
            FlowerDesc = flowerDesc;
            Stock = stock;
        }

        public Product() { }

        public override string ToString()
        {
            return $"ID{FlowerId}|Name:{FlowerName}|Season:{Season}|Description:{FlowerDesc}|Stock:{Stock}|Price:{Price}";
        }
    }
}
