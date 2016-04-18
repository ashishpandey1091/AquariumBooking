using D05.Controllers;
using D05.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace D05.Test_Folder
{
    public class HomeControllerTest
    {
        private readonly IServiceProvider _serviceProvider;

        // create a constructor to configure services
        public HomeControllerTest()
        {
            var efServiceProvider = new ServiceCollection();
            var services = new ServiceCollection();

            services.AddEntityFramework()
            .AddInMemoryDatabase()
            .AddDbContext<ApplicationDbContext>(
options => options.UseInMemoryDatabase());

            _serviceProvider = services.BuildServiceProvider();

        }

        [Fact]
        public void About_CreatesView()
        {  // return type is void not async task

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.About(); // controller uses sync methods (not async)

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);

        }


        [Fact]
        public void Contact_CreatesViewWithMessage()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.Contact();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Your contact page", viewResult.ViewData["Message"]);

        }

        [Fact]
        public void About_CreatesWithMessage()
        {
            //Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);

            //Act
            var result = controller.Contact();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Your about page", viewResult.ViewData["Message"]);
        }

        [Fact]
        public void Contact_CreatesView()
        {
            //Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);

            //Act
            var result = controller.Contact();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);
        }

        [Fact]
        public void FAQs_CreatesView()
        {
            //Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);

            //Act
            var result = controller.FAQs();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);
        }

        [Fact]
        public void FAQs_CreatesViewWithMessage()
        {
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.FAQs();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Your FAQs page", viewResult.ViewData["Message"]);
        }

        [Fact]
        public void TeamRoles_CreatesView()
        {
            //Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);

            //Act
            var result = controller.TeamRoles();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);
        }

        [Fact]
        public void TeamRoles_CreatesViewWithMessage()
        {
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.TeamRoles();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Your Team Roles page", viewResult.ViewData["Message"]);
        }

        [Fact]
        public void Milestones_CreatesView()
        {
            //Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);

            //Act
            var result = controller.Milestone();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);
        }

        [Fact]
        public void Milestone_CreatesViewWithMessage()
        {
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.Milestone();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Your Milestones page", viewResult.ViewData["Message"]);
        }


        [Fact]
        public void RemainingWorkPlan()
        {
            //Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);

            //Act
            var result = controller.RemainingWorkPlan();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName); 
            Assert.NotSame("your remaining work plan ",viewResult.ViewData);
            
        }



        [Fact]
        public void RemainingWorkPlan_ViewWithMessage()
        {
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.RemainingWorkPlan();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Your remaining work plan", viewResult.ViewData["Message"]);
        }

        [Fact]
        public void Index()
        {
            //Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);

            //Act
            var result = controller.Index();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotSame("your index page ", viewResult.ViewData);

        }

        [Fact]
        public void Index_ViewWithMessage()
        {
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new HomeController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Your Index page", viewResult.ViewData["Message"]);
        }



    }
}
