using ECommerce.BLL.AbstractServices;
using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services
{
    public class CartService : ICartService
    {
        public Dictionary<int, CartItem> MyCart = new Dictionary<int, CartItem>();

        public void AddItem(CartItem cartItem)
        {
            if (MyCart.ContainsKey(cartItem.Id))
            {
                MyCart[cartItem.Id].Quantity += 1;
                return;
            }
            MyCart.Add(cartItem.Id, cartItem);
        }

        public void UpdateItem(int key, short quantity)
        {
            if (MyCart.ContainsKey(key))
            {
                MyCart[key].Quantity = quantity;
                return;
            }
        }
    }
}
