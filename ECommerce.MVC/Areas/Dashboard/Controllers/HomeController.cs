using ECommerce.BLL.AbstractServices;
using ECommerce.DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IProductService _productService;

        public HomeController(IOrderService orderService, IOrderDetailService orderDetailService,UserManager<IdentityUser> userManager,IProductService productService)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _userManager = userManager;
            _productService = productService;
        }
        public IActionResult Index()
        {
            //Toplam Sipariş
            ViewBag.OrderCount = _orderService.GetTotalOrderCount();

            //Toplam Kullanıcı
            ViewBag.UserCount = _userManager.Users.Count();

            //Toplam Ürün
            ViewBag.TotalProduct = _productService.GetAllProducts().Count();

            //Toplam Gelir
            ViewBag.TotalRevenue = _orderService.GetTotalRevenue();

            ViewBag.Orders = _orderService.GetAllOrders();
            return View();
        }
    }
}
