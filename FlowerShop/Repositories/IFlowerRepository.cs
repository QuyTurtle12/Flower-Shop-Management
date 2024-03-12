using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFlowerRepository
    {
        void AddFlower(Flower flower);
        void UpdateFlower(Flower flower);
        void DeleteFlower(Flower flower);
        Flower GetFlowerById(int id);
        Dictionary<int, Flower> GetFlowerList();
    }
}
