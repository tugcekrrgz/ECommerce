using System.ComponentModel.DataAnnotations;

namespace ECommerce.MVC.Areas.Dashboard.Models.ViewModels
{
    public class ProductVM
    {
        [Required(ErrorMessage = "Ürün Adı Boş Geçilemez!")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Fiyat Boş Geçilemez!")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Stok Boş Geçilemez!")]
        public short UnitsInStock { get; set; }

        public string? Description { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        public int CategoryId { get; set; }
    }
}
