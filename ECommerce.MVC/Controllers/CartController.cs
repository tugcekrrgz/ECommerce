using ECommerce.BLL.AbstractServices;
using ECommerce.MVC.Models;
using ECommerce.MVC.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;

        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult AddToCard(int id)
        {
            var product = _productService.GetById(id);
            if (product != null)
            {
                Cart cartSession;

                if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet") == null)
                {
                    cartSession = new Cart();

                }
                else
                {
                    cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet");
                }

                CartItem cartItem = new CartItem();
                cartItem.Id = product.Id;
                cartItem.ProductName = product.ProductName;
                cartItem.UnitPrice = product.UnitPrice;

                cartSession.AddItem(cartItem);
                SessionHelper.SetJsonProduct(HttpContext.Session, "sepet", cartSession);


                return RedirectToAction("Index","Home");
            }
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult UpdateCart(int id, short quantity)
        {
            var cart = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet");
            cart.UpdateItem(id,quantity);
            SessionHelper.SetJsonProduct(HttpContext.Session, "sepet",cart);
            return RedirectToAction("MyCart");
        }

        [Authorize]
        public IActionResult MyCart()
        {
            return View();
            
        }
    }
}
