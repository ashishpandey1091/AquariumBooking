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
    public class BirthdayPartiesControllerTest
    {

        // use dependency injection - create a local IServiceProvider
        private readonly IServiceProvider _serviceProvider;

        public BirthdayPartiesControllerTest()
        {
            var efServiceProvider = new ServiceCollection();
            var services = new ServiceCollection();

            services.AddEntityFramework()
            .AddInMemoryDatabase()
            .AddDbContext<ApplicationDbContext>(
            options => options.UseInMemoryDatabase());

            _serviceProvider = services.BuildServiceProvider();
        }


        private static DbSet<BirthdayParty> CreateTestBirthdayParties(int numberOfLocations, ApplicationDbContext dbContext)
        {

            var BirthdayParties = Enumerable.Range(1, numberOfLocations).Select(n =>
                 new BirthdayParty()
                 {
                     AttendeesNumber = 10+n,
                     BirthdayPersonAge = 15+n,
                     BirthdayPersonName = "king"+n,
                     ContactNumber = "1234567890",
                     DateofRegistration = new DateTime(2016, 1, 1),
                     DateofVisit = new DateTime(2016, 1, 1),
                     FirstName = "Naruto"+n,
                     FoodDetails = "nothing"+n,
                     IsAdminAccepted = "Y" ,
                     LastName = "Hinata",
                     UserEmail = "something"+n+"@somthing.com"
                 });

            dbContext.AddRange(BirthdayParties);
            dbContext.SaveChanges();
            return dbContext.BirthdayParties;
        }


        [Fact]
        public void Events_Return_IndexView_NotNullWithTrueAssert()
        {

            // Arrange
            var numDummyObjects = 3;
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            CreateTestBirthdayParties(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new BirthdayPartiesController(dbContext);

            // Act
            var result = controller.Index();

            // Assert with checking Type of data.
            Assert.IsAssignableFrom<ViewResult>(result);



        }

        [Fact]
        public void Events_Return_IndexView_NotNull_With_False_Assert()
        {

            // Arrange
            var numDummyObjects = 3;
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            CreateTestBirthdayParties(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new BirthdayPartiesController(dbContext);

            // Act
            var result = controller.Index();

            // Assert with checking Type of data.
            Assert.IsAssignableFrom<ViewResult>(result);

        }


        [Fact]
        public void Events_Return_DetailView_NOTNull()
        {

            // Arrange
            var numDummyObjects = 3;
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            CreateTestBirthdayParties(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new BirthdayPartiesController(dbContext);

            // Act
            var result = controller.Details(1);

            // Assert with checking Type of data.
            Assert.False(result == null);

        }

        [Fact]
        public void Events_Return_EditView_NOTNull()
        {

            // Arrange
            var numDummyObjects = 3;
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            CreateTestBirthdayParties(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new BirthdayPartiesController(dbContext);

            // Act
            var result = controller.Edit(1);

            // Assert with checking Type of data.
            Assert.IsAssignableFrom<ViewResult>(result);

        }

        [Fact]
        public void Events_Return_List()
        {

            // Arrange
            var numDummyObjects = 3;
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            CreateTestBirthdayParties(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new BirthdayPartiesController(dbContext);

            // Act
            var result = dbContext.BirthdayParties.Count<BirthdayParty>();

            // Assert with checking Type of data.
            Assert.Equal(numDummyObjects, result);
            Assert.False(result < numDummyObjects);
            Assert.True(result == numDummyObjects);

        }

    }


}
