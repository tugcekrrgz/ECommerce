using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.AbstractServices
{
    public interface IShipperService
    {
        //List
        IEnumerable<Shipper> GetAllShippers();

        //Create
        string Create(Shipper shipper);

        //Update
        string Update(Shipper shipper);

        //Delete
        string Delete(int id);

        //Get
        Shipper GetById(int id);
    }
}
