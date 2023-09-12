using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractServices;
using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services
{
    public class ShipperService : IShipperService
    {
        private readonly IRepository<Shipper> _shipperRepository;

        public ShipperService(IRepository<Shipper> shipperRepository) 
        {
            _shipperRepository = shipperRepository;
        }
        public string Create(Shipper shipper)
        {
            return _shipperRepository.Create(shipper);
        }

        public string Delete(int id)
        {
            return _shipperRepository.Delete(id);
        }

        public IEnumerable<Shipper> GetAllShippers()
        {
            return _shipperRepository.GetAll().Where(x => x.Status==Entity.Enum.Status.Active).ToList();
        }

        public Shipper GetById(int id)
        {
            return _shipperRepository.GetById(id);
        }

        public string Update(Shipper shipper)
        {
            return _shipperRepository.Update(shipper);
        }
    }
}
