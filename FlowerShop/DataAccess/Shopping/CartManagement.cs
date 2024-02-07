using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
using BusinessObject.Shopping;

namespace DataAccess.Shopping
{
    public class CartManagement
    {
        //Singleton pattern
        private static CartManagement instance = null;
        private static readonly object instanceLock = new object();
        public static CartManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CartManagement();
                    }
                    return instance;
                }
            }
        }

        private List<CartItem> cart = new List<CartItem>();

        public void AddCartItem(CartItem cartItem)
        {
            CartItem existingItem = cart.FirstOrDefault(flower => flower.ProductId == cartItem.ProductId);
            if (existingItem != null)
            {
                //Update quantity if the product is already in the cart
                existingItem.Amount += cartItem.Amount;
            }
            else
            {
                cart.Add(cartItem);
            }
        }

        public bool RemoveCartItem(CartItem cartItem)
        {
            CartItem existingItem = cart.FirstOrDefault(flower => flower.ProductId == cartItem.ProductId);
            if (existingItem != null)
            {
                cart.Remove(existingItem);
                return true; // Remove successfully
            }
            return false; // Item not found in the cart
        }


        public List<CartItem> GetCartItems()
        {
            return cart;
        }
    }
}
