using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessObject.Models;
using DataAccess;
namespace Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Flower product);
        void UpdateProduct(Flower product);
        void DeleteProduct(Flower product);
        Dictionary<string, Flower> GetProductList();
        Flower GetProductById(string productId);
    }
}
