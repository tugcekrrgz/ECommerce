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
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderService(ECommerceContext context, IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public string Create(Order order)
        {
            /*
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return "Sipariş Oluşturuldu!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }*/
            return _orderRepository.Create(order);
        }

        public string Delete(int id)
        {
            return _orderRepository.Delete(id);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public string Update(Order order)
        {
            return _orderRepository.Update(order);
        }
    }
}
