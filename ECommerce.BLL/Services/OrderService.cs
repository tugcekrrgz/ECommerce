using ECommerce.BLL.Abstract;
using ECommerce.BLL.AbstractServices;
using ECommerce.Common.DTOs;
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
        private readonly ECommerceContext _context;
        private readonly IRepository<Order> _orderRepository;

        public OrderService(ECommerceContext context, IRepository<Order> orderRepository)
        {
            _context = context;
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

        public List<IGrouping<int, OrderDTO>> GetAllOrders()
        {
            var orderQuery = from o in _context.Orders
                         join od in _context.OrderDetails on o.Id equals od.OrderId
                         select new OrderDTO
                         {
                             Id = o.Id,
                             OrderDate = o.CreatedDate,
                             TotalPrice = od.Quantity * od.UnitPrice,
                             ShipperId=o.ShipperId
                         };
            var orders = orderQuery.GroupBy(x => x.Id).ToList();
            return orders;
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public OrderDTO GetOrderById(int id)
        {
            var order = from o in _context.Orders
                        join od in _context.OrderDetails on o.Id equals od.OrderId
                        where o.Id == id 
                        select new OrderDTO 
                        { 
                            Id = o.Id,
                            OrderDate = o.CreatedDate,
                            TotalPrice = od.Quantity * od.UnitPrice,
                            ShipperId = o.ShipperId
                        };
            return order.FirstOrDefault(x => x.Id==id);
        }

        public int GetTotalOrderCount()
        {
            return _context.Orders.Count();
        }

        public decimal GetTotalRevenue()
        {
            return _context.OrderDetails.Sum(x => x.UnitPrice*x.Quantity).Value;
        }

        public string Update(Order order)
        {
            return _orderRepository.Update(order);
        }
    }
}
