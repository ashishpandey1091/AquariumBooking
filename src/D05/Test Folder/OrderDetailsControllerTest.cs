using D05.Controllers;
using D05.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;

using Xunit;

namespace D05.Test_Folder
{
    public class OrderDetailsControllerTest
    {
        // use dependency injection - create a local IServiceProvider
        private readonly IServiceProvider _serviceProvider;

        public OrderDetailsControllerTest()
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
        public void OrderDetails_CreatesView()
        {  // return type is void not async task

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new OrderDetailsController(dbContext);

            // Act
            var result = controller.Create(); // controller uses sync methods (not async)

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);
        }


        [Fact]
        public void OrderDetails_ReturnView()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new OrderDetailsController(dbContext);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            //Assert.Same("Your contact page.", viewResult.ViewData["Message"]);

        }


        [Fact]
        public void OrderDetails_DetailsViewReturn()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new OrderDetailsController(dbContext);

            // Act

            var result = controller.Details(null);
            //var result2 = controller.Details(null);
            //var result3 = controller.Details(null);

            // Assert
            var viewResult = Assert.IsType<HttpNotFoundResult>(result);
            //var viewResult2 = Assert.IsType<ViewResult>(result2);
            //var viewResult3 = Assert.IsType<ViewResult>(result3);

            Assert.NotNull(viewResult);
            // Assert.NotNull(viewResult.);
            //Assert.NotNull(viewResult2);
            //Assert.NotNull(viewResult2.ViewData);
            //Assert.NotNull(viewResult3);
            //Assert.NotNull(viewResult3.ViewData);
            //Assert.Same("Your contact page.", viewResult.ViewData["Message"]);

        }

        [Fact]
        public void OrderDetails_Delete()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new EventsController(dbContext);

            // Act
            var result = controller.Delete(null);

            // Assert
            var viewResult = Assert.IsType<HttpNotFoundResult>(result);
            Assert.NotNull(viewResult);
            // Assert.NotNull(viewResult.ViewData);
            //Assert.Same("Your contact page.", viewResult.ViewData["Message"]);

        }

    }
}
