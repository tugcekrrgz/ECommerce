using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
