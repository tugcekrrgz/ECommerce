using ECommerce.BLL.AbstractServices;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Details(int id)
        {
            var product = _productService.GetById(id);
            if(product != null)
                return View(product);
            return RedirectToAction("Index","Home");
        }
    }
}
