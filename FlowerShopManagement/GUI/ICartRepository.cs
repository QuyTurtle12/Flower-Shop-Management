using BusinessObject.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICartRepository
    {
        void AddCartItem(CartItem product);
        bool RemoveCartItem(CartItem productId);
        List<CartItem> GetCartItems();
        bool checkCart(List<CartItem> cart);
        bool checkCartItem(CartItem item);
    }
}
