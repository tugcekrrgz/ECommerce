using ECommerce.MVC.Areas.Dashboard.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var viewModelUser = new UserVM
            {
                Users = _userManager.Users.ToList(),
                UserRoles = new Dictionary<string, List<string>>()
            };

            //Bütün kullanıcılarda dönecek. user değerinin roluünü userRole değişkenine aktaracak
            foreach (var user in viewModelUser.Users)
            {
                var userRole=_userManager.GetRolesAsync(user).Result;
                viewModelUser.UserRoles[user.Id] = userRole.ToList();
            }

            ViewBag.Roles=_roleManager.Roles.ToList();

            return View(viewModelUser) ;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterVM registerVM,List<string> roles)
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
                    if (roles.Count>0)
                    {
                        foreach (var role in roles)
                        {
                            await _userManager.AddToRoleAsync(user, role);
                        }
                    }
                    return RedirectToAction("Index");
                }
            }
                return View();
        }
    }
}
