using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.AbstractServices
{
    public interface IOrderService
    {
        //List
        IEnumerable<Order> GetAllOrders();

        //Create
        string Create(Order order);

        //Update
        string Update(Order order);

        //Delete
        string Delete(int id);

        //Get
        Order GetById(int id);
    }
}
