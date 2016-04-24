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
    public class ManageControllerTest
    {


        private readonly IServiceProvider _serviceProvider;

        // create a constructor to configure services
        public ManageControllerTest()
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
        public void AddPhoneNumber()
        {  // return type is void not async task

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ManageController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.AddPhoneNumber(); // controller uses sync methods (not async)

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);

        }



        [Fact]
        public void AddPhoneNumber_ViewWithMessage()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ManageController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.AddPhoneNumber();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Your Phonenumber ", viewResult.ViewData["Message"]);

        }


        [Fact]
        public void ChangePassword()
        {  // return type is void not async task

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ManageController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.ChangePassword(); // controller uses sync methods (not async)

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);

        }



        [Fact]
        public void ChangePassword_ViewMessage()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ManageController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.ChangePassword();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Change Password ", viewResult.ViewData["Message"]);

        }


        [Fact]
        public void SetPassword()
        {  // return type is void not async task

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ManageController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.SetPassword(); // controller uses sync methods (not async)

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.ViewName);
            Assert.NotNull(viewResult.ViewData);

        }



        [Fact]
        public void SetPassword_ViewMessage()
        {

            // Arrange
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            var controller = new ManageController(dbContext);  // home controller doesn't use dbcontext

            // Act
            var result = controller.SetPassword();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.NotNull(viewResult.ViewData);
            Assert.NotSame("Set Password ", viewResult.ViewData["Message"]);

        }

        int Add(int x, int y)
        {

            return x + y;

        }

       
        [Fact]
        public void EqualTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void NotEqualTest()
        {
            Assert.NotEqual(5, Add(2, 2));
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -1, -2)]
        [InlineData(-1, 1, 0)]
        public void TheoryAddExample(int a, int b, int c)
        {
            Assert.Equal(c, Add(a, b));
        }


    }
}
