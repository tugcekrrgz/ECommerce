using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.AbstractServices
{
    public interface IOrderDetailService
    {
        //List
        IEnumerable<OrderDetail> GetAllOrderDetails();

        //Create
        string Create(OrderDetail orderDetail);

        //Update
        string Update(OrderDetail orderDetail);

        //Delete
        string Delete(int id);

        //Get
        OrderDetail GetById(int id);
    }
}
