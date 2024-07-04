using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class FlowerDAO
    {
        // Singleton pattern
        private static FlowerDAO instance = null;
        private static readonly object instanceLock = new object();

        public static FlowerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new FlowerDAO();
                    }
                    return instance;
                }
            }
        }

        public Dictionary<int, Flower> GetFlowerList()
        {
            Dictionary<int, Flower> listFlowers = new Dictionary<int, Flower>();
            try
            {
                using (var context = new FlowerShopContext())
                {
                    listFlowers = context.Flowers.ToDictionary(flower => flower.Id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listFlowers;
        }

        public Flower GetFlowerById(int id)
        {
            Flower flower = null;
            try
            {
                using var context = new FlowerShopContext();
                flower = context.Flowers.SingleOrDefault(f => f.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flower;
        }

        private int orderIdGeneration()
        {
            using (var context = new FlowerShopContext())
            {
                int lastProductId = context.Flowers.Max(c => c.Id); // Retrieve the last used OrderId
                return lastProductId + 1; // Increment it by 1 to generate a new OrderId
            }
        }

        public void AddFlower(Flower flower)
        {
            using (var context = new FlowerShopContext())
            {
                flower.Id = orderIdGeneration();
                context.Flowers.Add(flower);
                context.SaveChanges();
            }
        }

        public void DeleteFlower(Flower flower)
        {
            using (var context = new FlowerShopContext())
            {
                context.Flowers.Remove(flower);
                context.SaveChanges();
            }
        }

        public void UpdateFlower(Flower flower)
        {
            using (var context = new FlowerShopContext())
            {
                context.Flowers.Update(flower);
                context.SaveChanges();
            }
        }
    }
}
