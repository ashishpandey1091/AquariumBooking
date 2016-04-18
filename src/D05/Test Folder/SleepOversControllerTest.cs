using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using D05.Controllers;
using D05.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;

namespace D05.Test_Folder
{
    public class SleepOversControllerTest
    {
        // use dependency injection - create a local IServiceProvider
        private readonly IServiceProvider _serviceProvider;

        public SleepOversControllerTest()
        {
            var efServiceProvider = new ServiceCollection();
            var services = new ServiceCollection();

            services.AddEntityFramework()
            .AddInMemoryDatabase()
            .AddDbContext<ApplicationDbContext>(
            options => options.UseInMemoryDatabase());

            _serviceProvider = services.BuildServiceProvider();
        }


        private static DbSet<SleepOver> CreateTestSleepOver(int numberOfLocations, ApplicationDbContext dbContext)
        {

            var SleepOvers = Enumerable.Range(1, numberOfLocations).Select(n =>
                 new SleepOver()
                 {
                     AttendeesNumber = 5 + n,
                     ContactNumber = "1234567890",
                     DateofRegistration = new DateTime(2016, 1, 1),
                     DateofVisit = new DateTime(2016, 1, 1),
                     IsAdminAccepted = "y",
                     UserEmail = "user" + n + "@gmail.com",
                     FirstName = "abc",
                     LastName = "efg"
                 });

            dbContext.AddRange(SleepOvers);
            dbContext.SaveChanges();
            return dbContext.SleepOvers;
        }

        [Fact]
        public void Trips_Return_IndexView_NotNullWithTrueAssert()
        {

            // Arrange
            var numDummyObjects = 4;
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            CreateTestSleepOver(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new SleepOversController(dbContext);

            // Act
            var result = controller.Index();

            // Assert with checking Type of data.
            Assert.IsAssignableFrom<ViewResult>(result);

        }

        [Fact]
        public void Trips_Return_IndexView_NotNull_With_False_Assert()
        {

            // Arrange
            var numDummyObjects = 4;
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            CreateTestSleepOver(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new SleepOversController(dbContext);

            // Act
            var result = controller.Index();

            // Assert with checking Type of data.
            Assert.IsAssignableFrom<ViewResult>(result);

        }


        [Fact]
        public void Trips_Return_DetailView_NOTNull()
        {

            // Arrange
            var numDummyObjects = 3;
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            CreateTestSleepOver(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new SleepOversController(dbContext);

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
            CreateTestSleepOver(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new SleepOversController(dbContext);

            // Act
            var result = controller.Edit(1);

            // Assert with checking Type of data.
            Assert.IsAssignableFrom<ViewResult>(result);

        }

        [Fact]
        public void Events_Return_List()
        {

            // Arrange
            var numDummyObjects = 4;
            var dbContext = _serviceProvider.GetRequiredService<ApplicationDbContext>();
            CreateTestSleepOver(numberOfLocations: numDummyObjects, dbContext: dbContext);
            var controller = new SleepOversController(dbContext);

            // Act
            var result = dbContext.SleepOvers.Count<SleepOver>();

            // Assert with checking Type of data.
            Assert.Equal(numDummyObjects, result);
            Assert.False(result < numDummyObjects);
            Assert.True(result == numDummyObjects);

        }
    }
}
