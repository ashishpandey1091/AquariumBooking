using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class CreateEventsController : Controller
    {
        private ApplicationDbContext _context;

        public CreateEventsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: CreateEvents
        public IActionResult Index()
        {
            return View(_context.CreateEvent.ToList());
        }

        // GET: CreateEvents/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CreateEvent createEvent = _context.CreateEvent.Single(m => m.EventID == id);
            if (createEvent == null)
            {
                return HttpNotFound();
            }

            return View(createEvent);
        }

        // GET: CreateEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CreateEvents/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateEvent createEvent)
        {
            if (ModelState.IsValid)
            {
                _context.CreateEvent.Add(createEvent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createEvent);
        }

        // GET: CreateEvents/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CreateEvent createEvent = _context.CreateEvent.Single(m => m.EventID == id);
            if (createEvent == null)
            {
                return HttpNotFound();
            }
            return View(createEvent);
        }

        // POST: CreateEvents/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CreateEvent createEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Update(createEvent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createEvent);
        }

        // GET: CreateEvents/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CreateEvent createEvent = _context.CreateEvent.Single(m => m.EventID == id);
            if (createEvent == null)
            {
                return HttpNotFound();
            }

            return View(createEvent);
        }

        // POST: CreateEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            CreateEvent createEvent = _context.CreateEvent.Single(m => m.EventID == id);
            _context.CreateEvent.Remove(createEvent);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
