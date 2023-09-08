using ECommerce.BLL.AbstractServices;
using ECommerce.Common;
using ECommerce.Entity.Entity;
using ECommerce.MVC.Areas.Dashboard.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace ECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public ProductController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAllProducts()) ;
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _categoryService.GetAllCategories().Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.Id.ToString()
            }); 
            return View();
        }


        [HttpPost]
        public IActionResult Create(ProductVM productVM, IFormFile productImage )
        {
            string path = "";
            var imageResult = "";

            //Gelen dosyanın tipini belirleme
            if (productImage != null)
            {
                imageResult = ImageUploader.ImageChangeName(productImage.FileName);
            }

            if(imageResult != "" && imageResult != "0")
            {
                productVM.Image = imageResult;

                path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\dist\\img",imageResult);

                using (var stream=new FileStream(path,FileMode.Create) )
                {
                    productImage.CopyToAsync(stream);
                }                
            }

            //Ürünü veritabanına kaydetme

            Product product = new Product
            {
                ProductName = productVM.ProductName,
                UnitPrice = productVM.UnitPrice,
                UnitsInStock = productVM.UnitsInStock,
                CategoryId = productVM.CategoryId,
                ImagePath = productVM.Image,
                Description = productVM.Description
            };
            var result = _productService.Create(product);
            TempData["Result"] = result;


            return View();
        }

    }
}
