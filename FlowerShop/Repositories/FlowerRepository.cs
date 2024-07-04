using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FlowerRepository : IFlowerRepository
    {
        public void AddFlower(Flower flower) => FlowerDAO.Instance.AddFlower(flower);

        public void UpdateFlower(Flower flower) => FlowerDAO.Instance.UpdateFlower(flower);

        public void DeleteFlower(Flower flower) => FlowerDAO.Instance.DeleteFlower(flower);

        public Flower GetFlowerById(int id) => FlowerDAO.Instance.GetFlowerById(id);

        public Dictionary<int, Flower> GetFlowerList() => FlowerDAO.Instance.GetFlowerList();
    }
}
