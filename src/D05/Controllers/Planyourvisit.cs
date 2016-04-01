using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using D05.Models;
using D05.ViewModels.Planyourvisit;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace D05.Controllers
{
    public class Planyourvisit : Controller
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public Planyourvisit(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult PlanYourVisit(string tab)
        {
            
            ViewData["Key"] = tab;
            ApplicationUser user = null;

            if (User.IsInRole("user"))
            {
                ViewData["loggedin"] = "true";
                user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            }
           
            

            Price price = _context.Prices.Single();

            if (price == null)
            {
                return HttpNotFound();
            }

            var viewModel = new ShoppingCartViewModel
            {
                Price = price,
                Event = _context.Events.ToList(),
                User = user

            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlanYourVisit(ShoppingCartViewModel shoppingCart)
        {
            ApplicationUser user = null;


            var viewModel = new ShoppingCartViewModel
            {
                Price = _context.Prices.Single(),
                Event = _context.Events.ToList(),
                User = user,
                OrderDetail = shoppingCart.OrderDetail

            };


            if (User.IsInRole("user"))
            {
                user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            }


            if (shoppingCart.OrderDetail != null)
                _context.OrderDetails.Add(shoppingCart.OrderDetail);

            if (shoppingCart.BirthDayParty != null)
            {
                BirthdayParty bp = shoppingCart.BirthDayParty;
                bp.IsAdminAccepted = "N/A";
                _context.BirthdayParties.Add(bp);

                viewModel = new ShoppingCartViewModel
                {

                    Event = _context.Events.ToList(),
                    User = user,


                };
                ViewData["birthday"] = "true";

            }

            if (shoppingCart.SchoolTrip != null)
            {
                SchoolTrip st = shoppingCart.SchoolTrip;
                st.IsAdminAccepted = "N/A";
                _context.SchoolTrips.Add(st);

                viewModel = new ShoppingCartViewModel
                {

                    Event = _context.Events.ToList(),
                    User = user,


                };
                ViewData["schooltrip"] = "true";

            }

            if (shoppingCart.SleepOver != null)
            {
                SleepOver so = shoppingCart.SleepOver;
                so.IsAdminAccepted = "N/A";
                _context.SleepOvers.Add(so);

                viewModel = new ShoppingCartViewModel
                {

                    Event = _context.Events.ToList(),
                    User = user,


                };
                ViewData["sleepover"] = "true";

            }


            
            if (shoppingCart.OrderDetail != null)
            {
                ViewData["orderplaced"] = "true";

                viewModel = new ShoppingCartViewModel
                {
                    Price = _context.Prices.Single(),
                    Event = _context.Events.ToList(),
                    User = user,
                    OrderDetail = shoppingCart.OrderDetail

                };
            }
            _context.SaveChanges();
            return View(viewModel);
        }





    }
}
