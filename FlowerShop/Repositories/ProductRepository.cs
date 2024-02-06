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
        public void AddProduct(Flower product) => ProductDAO.AddProduct(product);

        public void DeleteProduct(Flower product) => ProductDAO.DeleteProduct(product);

        public Dictionary<int, Flower> GetProductList() => ProductDAO.GetProductList();

        public Flower GetProductById(int id) => ProductDAO.GetProductById(id);

        public void UpdateProduct(Flower product) => ProductDAO.UpdateProduct(product);

    }
}
