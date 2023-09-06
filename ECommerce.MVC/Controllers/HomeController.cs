using ECommerce.BLL.AbstractServices;
using ECommerce.Common;
using ECommerce.MVC.Areas.Dashboard.Models.ViewModels;
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

        public HomeController(ICategoryService categoryService,IProductService productService,UserManager<IdentityUser> userManager)
        {
            _categoryService = categoryService;
            _productService = productService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //var categories=_categoryService.GetAllCategories();
            var products = _productService.GetAllProducts();
            return View();
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
            }
            return View();
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

    }
}
