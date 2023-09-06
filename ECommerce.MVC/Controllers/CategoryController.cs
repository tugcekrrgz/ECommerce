using ECommerce.BLL.AbstractServices;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductService _productService;

        public CategoryController(IProductService productService) 
        {
            _productService = productService;
        }
        public IActionResult GetProducts(int id)
        {
            var products=_productService.GetAllProducts().Where(x => x.CategoryId == id).ToList();
            return View(products);
        }
    }
}
