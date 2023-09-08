using ECommerce.BLL.AbstractServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Dashboard.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IProductService _productService;

        public OrderController(IOrderService orderService, IOrderDetailService orderDetailService, IProductService productService) 
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _productService = productService;
        }

        [Area("Dashboard")]
        public IActionResult Details(int id)
        {
            var order=_orderService.GetById(id);
            ViewBag.OrderDetails = _orderDetailService.GetAllOrderDetails();
            ViewBag.Products= _productService.GetAllProducts();
            return View(order);
        }
    }
}
