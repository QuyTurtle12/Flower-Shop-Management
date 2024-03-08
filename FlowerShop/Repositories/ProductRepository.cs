using BusinessObject;
using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Flower product) => ProductDAO.Instance.AddProduct(product);

        public void DeleteProduct(Flower product) => ProductDAO.Instance.DeleteProduct(product);

        public Dictionary<int, Flower> GetProductList() => ProductDAO.Instance.GetProductList();

        public Flower GetProductById(int id) => ProductDAO.Instance.GetProductById(id);

        public void UpdateProduct(Flower product) => ProductDAO.Instance.UpdateProduct(product);

        public void UpdateStock(int id, int amount) => ProductDAO.Instance.UpdateStock(id, amount);
    }
}
