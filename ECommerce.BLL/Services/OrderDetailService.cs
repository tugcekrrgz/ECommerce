using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractServices;
using ECommerce.DAL.Context;
using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IRepository<OrderDetail> _orderDetailRepository;

        public OrderDetailService(IRepository<OrderDetail> orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public string Create(OrderDetail orderDetail)
        {
            return _orderDetailRepository.Create(orderDetail);
        }

        public string Delete(int id)
        {
            return _orderDetailRepository.Delete(id);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _orderDetailRepository.GetAll();
        }

        public OrderDetail GetById(int id)
        {
            return _orderDetailRepository.GetById(id);
        }

        public string Update(OrderDetail orderDetail)
        {
            return _orderDetailRepository.Update(orderDetail);
        }
    }
}
