using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
<<<<<<< HEAD
=======
using D05.Controllers;
>>>>>>> 46765467cfe76bab7016517f3b77c7e1e129e80b
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
<<<<<<< HEAD
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<CreateEvent> Event { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
=======
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<CreateEvent> CreateEvent { get; set; }
>>>>>>> 46765467cfe76bab7016517f3b77c7e1e129e80b
    }
}
