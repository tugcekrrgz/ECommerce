using ECommerce.BLL.AbstractServices;
using ECommerce.DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    //[Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;

        public HomeController(IOrderService orderService, IOrderDetailService orderDetailService)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
        }
        public IActionResult Index()
        {
            ViewBag.OrderDetails=_orderDetailService.GetAllOrderDetails();
            return View(_orderService.GetAllOrders());
        }
    }
}
