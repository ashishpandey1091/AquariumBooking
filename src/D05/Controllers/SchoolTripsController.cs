using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class SchoolTripsController : Controller
    {
        private ApplicationDbContext _context;

        public SchoolTripsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: SchoolTrips
        public IActionResult Index()
        {
            return View(_context.SchoolTrips.ToList());
        }

        // GET: SchoolTrips/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SchoolTrip schoolTrip = _context.SchoolTrips.Single(m => m.SchoolTripID == id);
            if (schoolTrip == null)
            {
                return HttpNotFound();
            }

            return View(schoolTrip);
        }

        // GET: SchoolTrips/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SchoolTrips/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SchoolTrip schoolTrip)
        {
            if (ModelState.IsValid)
            {
                _context.SchoolTrips.Add(schoolTrip);
                _context.SaveChanges();
                return Redirect("/Admin/Index");
            }
            return View(schoolTrip);
        }

        // GET: SchoolTrips/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SchoolTrip schoolTrip = _context.SchoolTrips.Single(m => m.SchoolTripID == id);
            if (schoolTrip == null)
            {
                return HttpNotFound();
            }
            return View(schoolTrip);
        }

        // POST: SchoolTrips/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SchoolTrip schoolTrip)
        {
            if (ModelState.IsValid)
            {
                _context.Update(schoolTrip);
                _context.SaveChanges();
                return Redirect("/Admin/Index");
            }
            return View(schoolTrip);
        }

        // GET: SchoolTrips/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SchoolTrip schoolTrip = _context.SchoolTrips.Single(m => m.SchoolTripID == id);
            if (schoolTrip == null)
            {
                return HttpNotFound();
            }

            return View(schoolTrip);
        }

        // POST: SchoolTrips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            SchoolTrip schoolTrip = _context.SchoolTrips.Single(m => m.SchoolTripID == id);
            _context.SchoolTrips.Remove(schoolTrip);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}
