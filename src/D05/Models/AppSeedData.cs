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

            if (context.Prices.Any())
            {
                return;
            }

            if (!context.Roles.Any()) { 
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
            }

            context.Prices.Add(new Price()
            {
                AdultPrice = 75,
                ChildPrice = 15,
                OldAgePrice = 6

            });

            context.SaveChanges();

            if (!context.Events.Any()) {
                context.Events.AddRange(
                new Event()
                {
              //EventID =  1,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    EventDate = new DateTime(2000, 1, 1),//"1/1/2000",
              EventEndTime = null,
                    EventName = "Exhibit One",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //             EventID = 2,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                                        
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Exhibit Two",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //             EventID = 3,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Exhibit Three",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //            EventID = 4,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Exhibit Four",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //            EventID = 5,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Exhibit Five",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //             EventID = 6,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Exhibit Six",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //            EventID = 7,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Exhibit Seven",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //            EventID = 8,
              AdultPrice = 55,
                    ChildPrice = 25,
                    Description = "",
                    EventDate = new DateTime(2016, 6, 6),  //"6/6/2016",
                    EventStartTime = "16:00",
                    EventName = "Dolphin Show",
                    EventEndTime = "18:00",
                    IsSpecialEvent = true,
                    OldAgePrice = 20
                }, new Event()
                {
              //            EventID = 9,
              AdultPrice = 55,
                    ChildPrice = 25,
                    Description = "",
                    EventDate = new DateTime(2016, 6, 7),
                    EventEndTime = "18:00",
                    EventName = "Music Fountain Show",
                    EventStartTime = "16:00",
                    IsSpecialEvent = true,
                    OldAgePrice = 20
                }, new Event()
                {
              //            EventID = 10,
              AdultPrice = 55,
                    ChildPrice = 25,
                    Description = "",
                    EventDate = new DateTime(2016, 6, 8),
                    EventEndTime = "18:00",
                    EventName = "Coral Show",
                    EventStartTime = "16:00",
                    IsSpecialEvent = true,
                    OldAgePrice = 20
                }
               );
                context.SaveChanges();
            }




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
