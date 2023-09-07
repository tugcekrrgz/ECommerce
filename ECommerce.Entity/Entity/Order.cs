using ECommerce.Entity.Base;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Entity.Entity
{
    internal class Order:BaseClass
    {
        public DateTime? ShippedDate { get; set; }
        public int UserId { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
