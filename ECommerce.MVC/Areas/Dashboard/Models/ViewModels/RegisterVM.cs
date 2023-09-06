using System.ComponentModel.DataAnnotations;

namespace ECommerce.MVC.Areas.Dashboard.Models.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email Boş Geçilemez!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Boş Geçilemez!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrarı Boş Geçilemez!")]
        [Compare("Password", ErrorMessage ="Şifreler Uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
