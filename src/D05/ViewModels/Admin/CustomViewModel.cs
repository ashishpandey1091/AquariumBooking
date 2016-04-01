using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using D05.Models;

namespace D05.ViewModels.Admin
{
    public class CustomViewModel
    {
        public List<OrderDetail> Order{ get; set; }

        public List<Price> Price { get; set; }

        public List<Coupon> Coupons { get; set; }

        public List<Event> Events { get; set; }

        public Event eventNew { get; set; }
      
        public List<ApplicationUser> Users { get; set; }
    }
}
