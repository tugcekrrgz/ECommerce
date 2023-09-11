using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.AbstractServices
{
    public interface ICartService
    {
        //AddItem
        public void AddItem(CartItem cartItem);

        //UpdateItem
        public void UpdateItem(int key, short quantity);

        //DeleteItem

    }
}
