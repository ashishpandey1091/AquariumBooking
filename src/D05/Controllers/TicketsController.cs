using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class TicketsController : Controller
    {
        private ApplicationDbContext _context;

        public TicketsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Tickets
        public IActionResult Index()
        {
            var applicationDbContext = _context.Ticket.Include(t => t.Transaction);
            return View(applicationDbContext.ToList());
        }

        // GET: Tickets/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Ticket ticket = _context.Ticket.Single(m => m.TicketID == id);
            if (ticket == null)
            {
                return HttpNotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            ViewData["TransactionID"] = new SelectList(_context.Transaction, "TransactionID", "Transaction");
            return View();
        }

        // POST: Tickets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Ticket.Add(ticket);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["TransactionID"] = new SelectList(_context.Transaction, "TransactionID", "Transaction", ticket.TransactionID);
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Ticket ticket = _context.Ticket.Single(m => m.TicketID == id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            ViewData["TransactionID"] = new SelectList(_context.Transaction, "TransactionID", "Transaction", ticket.TransactionID);
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Update(ticket);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["TransactionID"] = new SelectList(_context.Transaction, "TransactionID", "Transaction", ticket.TransactionID);
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Ticket ticket = _context.Ticket.Single(m => m.TicketID == id);
            if (ticket == null)
            {
                return HttpNotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Ticket ticket = _context.Ticket.Single(m => m.TicketID == id);
            _context.Ticket.Remove(ticket);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
