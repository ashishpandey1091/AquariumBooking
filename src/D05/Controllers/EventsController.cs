using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class EventsController : Controller
    {
        private ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Events
        public IActionResult Index()
        {
            return View(_context.Events.ToList());
        }

        // GET: Events/Details/5
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

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Event eventNew)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(eventNew);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventNew);
        }

        // GET: Events/Edit/5
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

        // GET: Events/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
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

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Event eventNew = _context.Events.Single(m => m.EventID == id);
            _context.Events.Remove(eventNew);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
