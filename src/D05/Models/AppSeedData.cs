using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;
using Microsoft.AspNet.Mvc;

namespace D05.Models
{
    public static class AppSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if(context == null)
            {
                return;
            }

            
            
            if (context.Roles.Any()) { return; }



            context.Roles.AddRange(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            {
                Id = "1",
                Name = "admin"
            }, new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            {
                Id = "2",
                Name = "user"
            });
            context.SaveChanges();

            

            //context.Users.Add(new ApplicationUser()
            //{
            //    UserName = "sharanyarao60@gmail.com",
            //    Email = "sharanyarao60@gmail.com",
            //    FirstName = "sharanya",


            //});

            //context.SaveChanges();


            // var user = context.Users.Where(u => u.FirstName.Equals("sharau")).FirstOrDefault();


        }
    }
}
