using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class BirthdayPartiesController : Controller
    {
        private ApplicationDbContext _context;

        public BirthdayPartiesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: BirthdayParties
        public IActionResult Index()
        {
            return View(_context.BirthdayParties.ToList());
        }

        // GET: BirthdayParties/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            BirthdayParty birthdayParty = _context.BirthdayParties.Single(m => m.BirthdayPartyID == id);
            if (birthdayParty == null)
            {
                return HttpNotFound();
            }

            return View(birthdayParty);
        }

        // GET: BirthdayParties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BirthdayParties/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BirthdayParty birthdayParty)
        {
            if (ModelState.IsValid)
            {
                _context.BirthdayParties.Add(birthdayParty);
                _context.SaveChanges();
                return Redirect("/Admin/Index");
            }
            return View(birthdayParty);
        }

        // GET: BirthdayParties/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            BirthdayParty birthdayParty = _context.BirthdayParties.Single(m => m.BirthdayPartyID == id);
            if (birthdayParty == null)
            {
                return HttpNotFound();
            }
            return View(birthdayParty);
        }

        // POST: BirthdayParties/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BirthdayParty birthdayParty)
        {
            if (ModelState.IsValid)
            {
                _context.Update(birthdayParty);
                _context.SaveChanges();
                return Redirect("/Admin/Index");
            }
            return View(birthdayParty);
        }

        // GET: BirthdayParties/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            BirthdayParty birthdayParty = _context.BirthdayParties.Single(m => m.BirthdayPartyID == id);
            if (birthdayParty == null)
            {
                return HttpNotFound();
            }

            return View(birthdayParty);
        }

        // POST: BirthdayParties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            BirthdayParty birthdayParty = _context.BirthdayParties.Single(m => m.BirthdayPartyID == id);
            _context.BirthdayParties.Remove(birthdayParty);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}
