﻿using System.ComponentModel.DataAnnotations;

namespace ECommerce.MVC.Areas.Dashboard.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Email Boş Geçilemez!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Boş Geçilemez!")]
        public string Password { get; set; }

    }
}
