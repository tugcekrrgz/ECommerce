using ECommerce.Entity.Base;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Entity.Entity
{
    public class Order:BaseClass
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public DateTime? ShippedDate { get; set; }
        //public int UserId { get; set; }
        public virtual IdentityUser User { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public int? ShipperId { get; set; }
        public Shipper? Shipper { get; set; }
    }
}
