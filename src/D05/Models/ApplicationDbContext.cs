using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

using D05.Controllers;

using D05.Models;

namespace D05.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Event> Events { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<SchoolTrip> SchoolTrips { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Coupon> Coupons { get; set; }


    }
}