using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class AdminsController : Controller
    {
        private ApplicationDbContext _context;

        public AdminsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Admins
        public IActionResult Index()
        {
            return View(_context.Admin.ToList());
        }

        // GET: Admins/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Admin admin = _context.Admin.Single(m => m.AdminID == id);
            if (admin == null)
            {
                return HttpNotFound();
            }

            return View(admin);
        }

        // GET: Admins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admins/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Admin.Add(admin);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        // GET: Admins/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Admin admin = _context.Admin.Single(m => m.AdminID == id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admins/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Update(admin);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        // GET: Admins/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Admin admin = _context.Admin.Single(m => m.AdminID == id);
            if (admin == null)
            {
                return HttpNotFound();
            }

            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Admin admin = _context.Admin.Single(m => m.AdminID == id);
            _context.Admin.Remove(admin);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
