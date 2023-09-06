using ECommerce.MVC.Areas.Dashboard.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList()) ;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    Email= registerVM.Email,
                    UserName=registerVM.Username,
                };

                var result=await _userManager.CreateAsync(user,registerVM.ConfirmPassword);
                if(result.Succeeded) 
                {
                    return RedirectToAction("Index");
                }
            }
                return View();
        }
    }
}
