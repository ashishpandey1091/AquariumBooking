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

            if (!context.Events.Any()) {
                context.Events.AddRange(
                new Event()
                {
              //EventID =  1,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Journey to Atlantis features a small aquarium exhibit, \"Jewels of the Sea\", in its gift shop exit area. Inside, guests will find aquariabuilt into the floor and the ceiling of the exhibit, along with more traditional aquaria.Water ride enthusiasts are in for a rush as thislegendary heaven uncovers its darker side. This energizing flume ride/exciting ride cross breed treats you to more than its impart of shocks as you investigate dull,watery ways through the indented city before being flung from its entryways down an exciting dive into  the waters underneath.Get ready for the ultimate adventure ride, Journey to Atlantis!Travelling on water & high-speed rails, you'll be  chased by spirits who want to keep Atlantis & you for their own!",
                    EventDate = new DateTime(2000, 1, 1),//"1/1/2000",
              EventEndTime = null,
                    EventName = "Journey to Atlantis",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //             EventID = 2,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "This exhibit is open for visitors to stop in as many times as they'd like. Guests get a glimpse into the daily life of a dolphin how they learn, play and interact with each other—and can chat with our marine mammal experts to discover what it's like to care for, teach and build relationships with these incredible animals.You can appreciate swimming with dolphins and connect with them as they kiss you, cuddle with you, do aeronautical trapeze artistry for you, and complete off with an intriguing Boogie Push, where                                    the dolphin will push you over the water surface while you ride a boogie board. Magnificent! Also, the Swim Adventure system                                       includes the Belly Ride,  where you will clutch the dolphin's fins as he rides over the water. ",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Dolphin Notch",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //             EventID = 3,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Ascend high above SeaWorld for a scenery you'll always remember. Watch out over the magnificence of Mission Bay, the dark blue Pacific Ocean and the notable horizon. With clear skies, you can see up to a hundred miles in every directions.Just as SeaWorld                                    brought attention to the plight of the manatee with the attraction \"Manatee Rescue,\" which created interest that helped to save                                    the species, TurtleTrek®'s 3D 360° theatre showcases the vulnerable sea turtle and asks everyday heroes across the globe to help                                    make a difference in saving animals in the wild.And when you leave this incredible attraction, hopefully you'll be inspired to                                      help make the world a better place by doing even the smallest things. Remember, it has to start somewhere. See how you can turn                                     into an Everyday Hero too.",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Seaworld Tower",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //            EventID = 4,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "The walrus (Odobenus rosmarus) is a large marine mammal with flippers, a broad head, short muzzle, small eyes, tusks and                                     whiskers.Scientists recognize two subspecies of walrus – the Atlantic walrus and the Pacific walrus.Walruses are cinnamon brown in                                     color.Simulators meets brave experience as you leave on an exciting plane helicopter ride through the stunning, hazardous, frigid                                     scenes of the solidified north. Placed yourself in your pilot's hands as he moves misleading solidified crests and valleys on the                                      way to Base Station Wild Arctic—a spot where superb beluga whales and walruses have transformed Mother Nature's most difficult                                      conditions into a polar play. ",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Walrus Skerry",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //            EventID = 5,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "Their amazing size and savage chasing aptitudes have earned executioner whales the title of \"top predator of the sea.\"Their particu-                                    lar  high contrast hue — troublesome hue — may improve their chasing capacities. This kind of shading example repudiates the                                           exuctioner whale's body shape and in the glinting sifting daylight of the ocean, different creatures may not perceive an executioner                                        whale as a potential predator. Their eating methodologies differ starting with one area then onto the next, however generally                                           comprise of fishes, squids, seabirds (counting penguins),and marine vertebrates.Executioner whales live in all the seas of the world                                     They're most inexhaustible in the Arctic, Antarctic, and territories of chilly water upwelling where the supplement rich water is                                      flourished with marine life. They live in cases — firm long haul social gatherings fundamentally made out of matrilineal gatherings                                     that incorporate a female whale, her posterity etc. ",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Killer Whales",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //             EventID = 6,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = "                                    The Coral Reef Gallery is an exceptional perspective into a standout amongst the most excellent and assorted biological systems on                                      the planet - a natural surroundings regularly visited just by experienced divers.The coral reef display reproduces a 60-foot plunge                                     beginning in shallow-water reefs and plummeting to more profound waters. Every survey window exhibits a micro living space which                                        changes as the depth increases.Stop by to see our one-of-a-kind coral reef gallery today! Often thought of as rocks or plants, corals                                    are actually made up of invertebrates called polyps. These polyps can range in size from a millimeter to a foot in diameter. The polyps                                      group together, forming a colony, and use calcium carbonate from the ocean to build a protective skeleton. ",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Coral Reef",
                    EventStartTime = null,
                    IsSpecialEvent = false,
                    OldAgePrice = 0
                }, new Event()
                {
              //            EventID = 7,
              AdultPrice = 0,
                    ChildPrice = 0,
                    Description = " The ocean lion stars perform a portion of the gymnastic and athletic practices which include:                                     Olympic-style plunges on a high-plunging stage                                     Effective swimming                                      Obstacle and high jumping                                     Balancing acts                                     Exercises in careful control                                      Lots of splashes and even more surprises While in front of an audience with the creatures, our coaches                                    clarify ocean lion conduct and uplifting feedback preparing, creature fun truths and the requirement for                                    rationing the ocean lions' sea environment.",
                    EventDate = new DateTime(2000, 1, 1),
                    EventEndTime = null,
                    EventName = "Danty Sealions",
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
              EventEndTime = "16:00",
                    EventName = "Dolphin Show",
                    EventStartTime = "18:00",
                    IsSpecialEvent = true,
                    OldAgePrice = 20
                }, new Event()
                {
              //            EventID = 9,
              AdultPrice = 55,
                    ChildPrice = 25,
                    Description = "",
                    EventDate = new DateTime(2016, 6, 7),
                    EventEndTime = "16:00",
                    EventName = "Music Fountain Show",
                    EventStartTime = "18:00",
                    IsSpecialEvent = true,
                    OldAgePrice = 20
                }, new Event()
                {
              //            EventID = 10,
              AdultPrice = 55,
                    ChildPrice = 25,
                    Description = "",
                    EventDate = new DateTime(2016, 6, 8),
                    EventEndTime = "16:00",
                    EventName = "Coral Show",
                    EventStartTime = "18:00",
                    IsSpecialEvent = true,
                    OldAgePrice = 20
                }, new Event()
                {
              //            EventID = 11,
              AdultPrice = 55,
                    ChildPrice = 25,
                    Description = "",
                    EventDate = new DateTime(2016, 6, 9),
                    EventEndTime = "16:00",
                    EventName = "Penguin show",
                    EventStartTime = "18:00",
                    IsSpecialEvent = true,
                    OldAgePrice = 20
                }, new Event()
                {
              //            EventID = 12,
              AdultPrice = 55,
                    ChildPrice = 25,
                    Description = "",
                    EventDate = new DateTime(2016, 6, 10),
                    EventEndTime = "16:00",
                    EventName = "sea lion show",
                    EventStartTime = "18:00",
                    IsSpecialEvent = true,
                    OldAgePrice = 20
                }, new Event()
                {
              //            EventID = 13,
              AdultPrice = 55,
                    ChildPrice = 25,
                    Description = "",
                    EventDate = new DateTime(2016, 6, 11),
                    EventEndTime = "16:00",
                    EventName = "Mermaid Shows",
                    EventStartTime = "18:00",
                    IsSpecialEvent = true,
                    OldAgePrice = 20
                });
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
