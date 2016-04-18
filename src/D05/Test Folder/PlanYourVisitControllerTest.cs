using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using D05.Models;
using D05.Controllers;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace D05.Test_Folder
{

     public class PlanYourVisitControllerTest
    {

        private readonly IServiceProvider _serviceProvider;



        public PlanYourVisitControllerTest()
        {
           var efServiceProvider = new ServiceCollection();

            var services = new ServiceCollection();

             services.AddEntityFramework()
            .AddInMemoryDatabase()
            .AddDbContext<ApplicationDbContext>(
            options => options.UseInMemoryDatabase());

            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddLogging();
            services.AddOptions();
            _serviceProvider = services.BuildServiceProvider();
            
        }


        [Fact]
        public void PlanYourVisitView()
        {
            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = _serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            
            var controller = new Planyourvisit(dbContext,userManager);
            
            String tab = "hours";
           

            // Act
            var result = controller.PlanYourVisit(tab);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotNull(viewResult.ViewData);
            Assert.Same("hours", viewResult.ViewData["Key"]);
        }

    }
}
