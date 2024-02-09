using BusinessObject.Shopping;
using DataAccess.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CartRepository : ICartRepository
    {
        public void AddCartItem(CartItem product)
        {
            CartManagement.Instance.AddCartItem(product);
        }

        public bool checkCart(List<CartItem> cart)
        {
            return CartManagement.Instance.checkCart(cart);
        }

        public bool checkCartItem(CartItem item)
        {
            return CartManagement.Instance.checkCartItem(item);
        }

        public List<CartItem> GetCartItems()
        {
            return CartManagement.Instance.GetCartItems();
        }

        public bool RemoveCartItem(CartItem product)
        {
            return CartManagement.Instance.RemoveCartItem(product);
        }


    }
}
