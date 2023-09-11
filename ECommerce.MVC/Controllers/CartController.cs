using ECommerce.BLL.AbstractServices;
using ECommerce.BLL.Services;
using ECommerce.Common;
using ECommerce.Entity.Entity;
using ECommerce.MVC.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.MVC.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IShipperService _shipperService;

        public CartController(IProductService productService, UserManager<IdentityUser> userManager, IOrderService orderService, IOrderDetailService orderDetailService, IShipperService shipperService)
        {
            _productService = productService;
            _userManager = userManager;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _shipperService = shipperService;
        }
        public IActionResult AddToCard(int id)
        {
            var product = _productService.GetById(id);
            if (product != null)
            {
                CartService cartService;

                if (SessionHelper.GetProductFromJson<CartService>(HttpContext.Session, "sepet") == null)
                {
                    cartService = new CartService();

                }
                else
                {
                    cartService = SessionHelper.GetProductFromJson<CartService>(HttpContext.Session, "sepet");
                }

                CartItem cartItem = new CartItem();
                cartItem.Id = product.Id;
                cartItem.ProductName = product.ProductName;
                cartItem.UnitPrice = product.UnitPrice;

                cartService.AddItem(cartItem);
                SessionHelper.SetJsonProduct(HttpContext.Session, "sepet", cartService);


                return RedirectToAction("Index","Home");
            }
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult UpdateCart(int id, short quantity)
        {
            var cart = SessionHelper.GetProductFromJson<CartService>(HttpContext.Session, "sepet");
            cart.UpdateItem(id,quantity);
            SessionHelper.SetJsonProduct(HttpContext.Session, "sepet", cart);
            return RedirectToAction("MyCart");
        }

        [Authorize]
        public IActionResult MyCart()
        {
            /*ViewBag.Shippers = _shipperService.GetAllShippers().Select(x => new SelectListItem
            {
                Text = x.CompanyName,
                Value = x.Id.ToString()
            });*/
            return View();
        }
        

        [Authorize]
        public async Task<IActionResult> CompleteCart()
        {
            CartService cart = SessionHelper.GetProductFromJson<CartService>(HttpContext.Session, "sepet");

            //Order
            Order order = new Order();
            var user = await _userManager.GetUserAsync(User);
            order.User = user;
            _orderService.Create(order);

            //Order Detail
            foreach (var item in cart.MyCart)
            {
                OrderDetail orderDetail = new OrderDetail();
                Product product = _productService.GetById(item.Value.Id);
                orderDetail.Product = product;
                orderDetail.Quantity = item.Value.Quantity;
                orderDetail.UnitPrice = item.Value.UnitPrice;


                orderDetail.Order = order;

                order.OrderDetails.Add(orderDetail);
                _orderDetailService.Create(orderDetail);
            }

            //Mail gönderimi
            MailSender.SendEmail(user.Email, "Siparişiniz alındı!", $"{order.Id} numaralı siparişiniz oluşturuldu. Kargoya verildiğinde bilgilendirileceksiniz.");

            //Sepetin boşaltılması

            SessionHelper.RemoveSession(HttpContext.Session, "sepet");


            return RedirectToAction("Confirmation", order);
        }


        public IActionResult Confirmation(Order order)
        {
            return View(order);
        }
    }
}
