using System.ComponentModel.DataAnnotations;

namespace ECommerce.MVC.Areas.Dashboard.Models.ViewModels
{
    public class CategoryVM
    {
        [Required(ErrorMessage ="Kategori Adı Boş Geçilemez!")]
        public string CategoryName { get; set; }

        
        public string Description { get; set; }
    }
}
