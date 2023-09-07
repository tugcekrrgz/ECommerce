﻿namespace ECommerce.MVC.Models
{
    public class Cart
    {
        //public List<CartItem> CartItems=new List<CartItem>();

        /*
        public Dictionary<int,string> Plakalar=new Dictionary<int,string>();
        public Cart()
        {
            Plakalar.Add(34,"İstanbul");
            Plakalar.Add(6,"Ankara");
        }
        */

        //todo: ICart oluştur abstract service de ve sonra car concrete oluştur.

        public Dictionary<int,CartItem> _myCart=new Dictionary<int,CartItem>();
        public void AddItem(CartItem cartItem)
        {
            if (_myCart.ContainsKey(cartItem.Id))
            {
                _myCart[cartItem.Id].Quantity += 1;
                return;
            }
            _myCart.Add(cartItem.Id,cartItem);
        }

        public void UpdateItem(int key, short quantity)
        {
            if (_myCart.ContainsKey(key))
            {
                _myCart[key].Quantity = quantity;
                return;
            }
        }
    }
}
