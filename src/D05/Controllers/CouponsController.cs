using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class CouponsController : Controller
    {
        private ApplicationDbContext _context;

        public CouponsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Coupons
        public IActionResult Index()
        {
            return View(_context.Coupons.ToList());
        }

        // GET: Coupons/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Coupons coupons = _context.Coupons.Single(m => m.CouponID == id);
            if (coupons == null)
            {
                return HttpNotFound();
            }

            return View(coupons);
        }

        // GET: Coupons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coupons/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Coupons coupons)
        {
            if (ModelState.IsValid)
            {
                _context.Coupons.Add(coupons);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coupons);
        }

        // GET: Coupons/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Coupons coupons = _context.Coupons.Single(m => m.CouponID == id);
            if (coupons == null)
            {
                return HttpNotFound();
            }
            return View(coupons);
        }

        // POST: Coupons/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Coupons coupons)
        {
            if (ModelState.IsValid)
            {
                _context.Update(coupons);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coupons);
        }

        // GET: Coupons/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Coupons coupons = _context.Coupons.Single(m => m.CouponID == id);
            if (coupons == null)
            {
                return HttpNotFound();
            }

            return View(coupons);
        }

        // POST: Coupons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Coupons coupons = _context.Coupons.Single(m => m.CouponID == id);
            _context.Coupons.Remove(coupons);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
