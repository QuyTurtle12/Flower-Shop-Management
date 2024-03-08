using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDTO
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int SaleAmount { get; set; }
        public ProductDTO() { }

        public List<ProductDTO> MapFlowerToDTO(List<Flower> flowers)
        {
            List<ProductDTO> productDTOs = (List<ProductDTO>)flowers.Select(flower => new ProductDTO
            {
                Id = flower.Id,
                Name = flower.Name,
                SaleAmount = 0
            }).ToList();
            return productDTOs;
        }
    }
}
