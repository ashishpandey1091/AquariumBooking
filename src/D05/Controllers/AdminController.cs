using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using D05.Models;
using D05.ViewModels.Admin;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace D05.Controllers
{
    public class AdminController : Controller
    {

        private ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            var viewModel = new CustomViewModel
            {
                
                Events = _context.Events.ToList(),
                Price = _context.Prices.ToList(),
                Order = _context.OrderDetails.ToList(),
                Coupons = _context.Coupons.ToList(),
                Users = _context.Users.ToList(),
                birthdayparties = _context.BirthdayParties.ToList(),
                sleepovers = _context.SleepOvers.ToList(),
                schooltrips = _context.SchoolTrips.ToList(),

                eventNew = new Event()

            };
            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Event eventType)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(eventType);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventType);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Event eventNew = _context.Events.Single(m => m.EventID == id);
            if (eventNew == null)
            {
            return HttpNotFound();
        }

            return View(eventNew);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Event eventNew = _context.Events.Single(m => m.EventID == id);
            if (eventNew == null)
            {
            return HttpNotFound();
        }
            return View(eventNew);
        }



        // POST: Events/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Event eventNew)
        {
            if (ModelState.IsValid)
            {
                _context.Update(eventNew);
        _context.SaveChanges();
                return RedirectToAction("Index");
        }
            return View(eventNew);
        }


        //public IActionResult EditUsers(String id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    ApplicationUser user = _context.Users.Single(m => m.Id == id);
        //    if (user == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(user);
        //}



        //// POST: Events/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult EditUsers(ApplicationUser user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(user);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(user);
        //}
    }

}
