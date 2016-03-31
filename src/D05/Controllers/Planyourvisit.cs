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

            if (User.IsInRole("user"))
            {
                user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            }

            
            
                _context.OrderDetails.Add(shoppingCart.OrderDetail);
                _context.SaveChanges();

            ViewData["orderplaced"] = "true";

            var viewModel = new ShoppingCartViewModel
            {
                Price = _context.Prices.Single(),
                Event = _context.Events.ToList(),
                User = user,
                OrderDetail = shoppingCart.OrderDetail

            };

            return View(viewModel);
        }





    }
}
