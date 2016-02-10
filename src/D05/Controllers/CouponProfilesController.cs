using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class CouponProfilesController : Controller
    {
        private ApplicationDbContext _context;

        public CouponProfilesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: CouponProfiles
        public IActionResult Index()
        {
            return View(_context.CouponProfile.ToList());
        }

        // GET: CouponProfiles/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CouponProfile couponProfile = _context.CouponProfile.Single(m => m.ProfileID == id);
            if (couponProfile == null)
            {
                return HttpNotFound();
            }

            return View(couponProfile);
        }

        // GET: CouponProfiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CouponProfiles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CouponProfile couponProfile)
        {
            if (ModelState.IsValid)
            {
                _context.CouponProfile.Add(couponProfile);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(couponProfile);
        }

        // GET: CouponProfiles/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CouponProfile couponProfile = _context.CouponProfile.Single(m => m.ProfileID == id);
            if (couponProfile == null)
            {
                return HttpNotFound();
            }
            return View(couponProfile);
        }

        // POST: CouponProfiles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CouponProfile couponProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Update(couponProfile);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(couponProfile);
        }

        // GET: CouponProfiles/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CouponProfile couponProfile = _context.CouponProfile.Single(m => m.ProfileID == id);
            if (couponProfile == null)
            {
                return HttpNotFound();
            }

            return View(couponProfile);
        }

        // POST: CouponProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            CouponProfile couponProfile = _context.CouponProfile.Single(m => m.ProfileID == id);
            _context.CouponProfile.Remove(couponProfile);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
