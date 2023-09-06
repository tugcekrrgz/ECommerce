using Microsoft.AspNetCore.Identity;

namespace ECommerce.MVC.Areas.Dashboard.Models.ViewModels
{
    public class UserVM
    {
        public List<IdentityUser> Users { get; set; }

        //Bir kullanıcının birden fazla rolü olabilir.
        public Dictionary<string,List<string>> UserRoles { get; set; }
    }
}
