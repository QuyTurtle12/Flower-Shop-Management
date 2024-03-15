using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessObject.Models;

namespace DataAccess
{
    public class ProductDAO
    {
        //Singleton pattern
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get{ 
               lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public Dictionary<int,Flower> GetProductList()
        {
            Dictionary<int, Flower> listProduct = new Dictionary<int, Flower>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    listProduct = context.Flowers.ToDictionary(Flower => Flower.Id);
                }
            }
            catch (Exception e)
            {
                throw new Exception (e.Message);
            }
            return listProduct;
        }

        public Flower GetProductById(int Id) {
            Flower product = null;
            try
            {
                using var context = new FlowerShopContext();
                product = context.Flowers.SingleOrDefault(f => f.Id == Id);
            }
            catch (Exception  ex)
            {
                throw new Exception (ex.Message);
            }
            return product;
        }

        public void UpdateStock(int id, int amount)
        {
            using var context = new FlowerShopContext();
            var flower = context.Flowers.Find(id);
            if (flower == null) throw new Exception($"Flower with ID {id} not found.");

            // Check if the stock adjustment will result in negative stock
            if (flower.Stock + amount < 0)
            {
                throw new Exception("Out of stock.");
            }

            flower.Stock += amount;
            context.SaveChanges();
        }

        public void AddProduct(Flower product) {
            // Logic to insert product in the database
        }
        public void DeleteProduct(Flower product) {
            // Logic to delete product in the database
        }
        public void UpdateProduct(Flower product) {
            // Logic to update the existing product in the database
        }
    }
}
