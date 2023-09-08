using ECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Entity
{
    public class Shipper:BaseClass
    {
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Order> Orders { get; set; }
    }
}
