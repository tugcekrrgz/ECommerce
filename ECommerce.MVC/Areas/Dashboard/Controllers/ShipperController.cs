using ECommerce.BLL.AbstractServices;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ShipperController : Controller
    {
        private readonly IShipperService _shipperService;

        public ShipperController(IShipperService shipperService)
        {
            _shipperService = shipperService;
        }
        public IActionResult Index()
        {
            //shipperleri listele ekle güncelle
            return View(_shipperService.GetAllShippers());
        }
    }
}
