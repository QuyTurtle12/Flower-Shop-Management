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

        public static Dictionary<int,Flower> GetProductList()
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

        public static Flower GetProductById(int Id) {
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

        public static void AddProduct(Flower product) {
            // Logic to insert product in the database
        }
        public static void DeleteProduct(Flower product) {
            // Logic to delete product in the database
        }
        public static void UpdateProduct(Flower product) {
            // Logic to update the existing product in the database
        }
    }
}
