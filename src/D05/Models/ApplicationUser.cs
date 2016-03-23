using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace D05.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int Age { get; internal set; }

        public string Answer { get; internal set; }

        public string FirstName { get; internal set; }

        public string LastName { get; internal set; }

        public string Question { get; internal set; }

        public virtual ICollection<OrderDetail> OrderDetails { get;  set; }

        // public virtual ICollection<Coupon> Coupons { get;  set; }
    }
}
