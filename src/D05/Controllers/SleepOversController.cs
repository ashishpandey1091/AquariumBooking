using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class SleepOversController : Controller
    {
        private ApplicationDbContext _context;

        public SleepOversController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: SleepOvers
        public IActionResult Index()
        {
            return View(_context.SleepOvers.ToList());
        }

        // GET: SleepOvers/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SleepOver sleepOver = _context.SleepOvers.Single(m => m.SleepOverID == id);
            if (sleepOver == null)
            {
                return HttpNotFound();
            }

            return View(sleepOver);
        }

        // GET: SleepOvers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SleepOvers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SleepOver sleepOver)
        {
            if (ModelState.IsValid)
            {
                _context.SleepOvers.Add(sleepOver);
                _context.SaveChanges();
                return Redirect("/Admin/Index");
            }
            return View(sleepOver);
        }

        // GET: SleepOvers/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SleepOver sleepOver = _context.SleepOvers.Single(m => m.SleepOverID == id);
            if (sleepOver == null)
            {
                return HttpNotFound();
            }
            return View(sleepOver);
        }

        // POST: SleepOvers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SleepOver sleepOver)
        {
            if (ModelState.IsValid)
            {
                _context.Update(sleepOver);
                _context.SaveChanges();
                return Redirect("/Admin/Index");
            }
            return View(sleepOver);
        }

        // GET: SleepOvers/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            SleepOver sleepOver = _context.SleepOvers.Single(m => m.SleepOverID == id);
            if (sleepOver == null)
            {
                return HttpNotFound();
            }

            return View(sleepOver);
        }

        // POST: SleepOvers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            SleepOver sleepOver = _context.SleepOvers.Single(m => m.SleepOverID == id);
            _context.SleepOvers.Remove(sleepOver);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}
