using D05.Controllers;
using D05.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ViewFeatures;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;

using Xunit;

namespace D05.Test_Folder
{
    public class ExhibitsControllerTest
    {
        // use dependency injection - create a local IServiceProvider
        private readonly IServiceProvider _serviceProvider;

        public ExhibitsControllerTest()
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
        public void Events_ReturnExhbitView()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ExhibitsController(dbContext);

            // Act
            var result = controller.Exhibits("exone");

            // Assert
            Assert.IsAssignableFrom<ViewResult>(result);

        }



        [Fact]
        public void Events_ReturnView_NotNull()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ExhibitsController(dbContext);

            // Act
            var result = controller.Exhibits("exone");

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
        }

        [Fact]
        public void Events_ReturnView_WithViewData()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ExhibitsController(dbContext);

            // Act
            var result = controller.Exhibits("exone");

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsAssignableFrom<ViewDataDictionary>(viewResult.ViewData);
            //Assert.Same("exone", viewResult.ViewData["key"]);
            //Assert.Same("Your contact page.", viewResult.ViewData["Message"]);


        }

        [Fact]
        public void Events_ReturnView_NotNull_ViewData_Notnull()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ExhibitsController(dbContext);

            // Act
            var result = controller.Exhibits("exone");

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
           
            Assert.NotNull(viewResult.ViewData);
            
           


        }

        [Fact]
        public void Events_ReturnView_ViewData_CorrectValue()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ExhibitsController(dbContext);

            // Act
            var result = controller.Exhibits("exone");

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Same("exone", viewResult.ViewData["key"]);
            var data = viewResult.GetType();
            Console.WriteLine(data + " I'm here");
            //Assert.Same("Your contact page.", viewResult.ViewData["Message"]);


        }

       




    }
}
