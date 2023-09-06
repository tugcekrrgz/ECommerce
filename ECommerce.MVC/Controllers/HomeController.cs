using ECommerce.BLL.AbstractServices;
using ECommerce.Common;
using ECommerce.MVC.Areas.Dashboard.Models.ViewModels;
using ECommerce.MVC.Models;
using ECommerce.MVC.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace ECommerce.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public HomeController(ICategoryService categoryService,IProductService productService,UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _categoryService = categoryService;
            _productService = productService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
           var categories=_categoryService.GetAllCategories();
            ViewBag.Categories = categories;
            var products = _productService.GetAllProducts();
            return View(products);
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM )
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByEmailAsync(loginVM.Email);

                if(user != null)
                {
                    var result= await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Register()
        {
            MailSender.SendEmail("tugcekaragoz9@gmail.com","Test","Bu mail proje tarafından iletildi.");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser
                {
                    Email= registerVM.Email,
                    UserName=registerVM.Username
                };

                var result= await _userManager.CreateAsync(user,registerVM.Password);

                if(result.Succeeded) 
                { 
                    var token=await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var encodeToken = HttpUtility.UrlEncode(token.ToString());

                    

                    string confirmationLink = Url.Action("Confirmation", "Home", new { id=user.Id, token=encodeToken },Request.Scheme);


                    MailSender.SendEmail(registerVM.Email,"Üyelik Aktivasyon", $"{registerVM.Username} kayıt işleminiz başarılı! Üyeliğinizi aktif hale getirebilmek için linke tıklayın : {confirmationLink}");

                    return RedirectToAction("Index");
                }
                else
                {
                    List<string> errors = new List<string>();
                    foreach (var err in result.Errors)
                    {
                        errors.Add(err.Description);
                    }
                    TempData["Error"]=errors;
                }
            }
            return View(registerVM);
        }

        public async Task<IActionResult> Confirmation(string? id, string? token)
        {
            var user=await _userManager.FindByIdAsync(id);
            if(user != null)
            {
                var decodeToken = HttpUtility.UrlDecode(token);
                var result=await _userManager.ConfirmEmailAsync(user,decodeToken);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult AddToCard(int id)
        {
            var product=_productService.GetById(id);
            if(product != null)
            {
                Cart cartSession;

                if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session,"sepet") == null)
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
                cartItem.UnitPrice= product.UnitPrice;

                cartSession.AddItem(cartItem);
                SessionHelper.SetJsonProduct(HttpContext.Session,"sepet",cartSession);


                return RedirectToAction("Index");                
            }
            return RedirectToAction("Index");            
        }


        public IActionResult MyCart()
        {
            if (User.Identity.IsAuthenticated)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }



    }
}
