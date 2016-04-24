using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using D05.Models;

namespace D05.Controllers
{
    public class OrderDetailsController : Controller
    {
        private ApplicationDbContext _context;

        public OrderDetailsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: OrderDetails
        public IActionResult Index()
        {
            return View(_context.OrderDetails.ToList());
        }

        // GET: OrderDetails/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            OrderDetail orderDetail = _context.OrderDetails.Single(m => m.OrderDetailID == id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }

            return View(orderDetail);
        }

        // GET: OrderDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderDetails/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                _context.OrderDetails.Add(orderDetail);
                _context.SaveChanges();
                return Redirect("/Admin/Index");
            }
            return View(orderDetail);
        }

        // GET: OrderDetails/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            OrderDetail orderDetail = _context.OrderDetails.Single(m => m.OrderDetailID == id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Update(orderDetail);
                _context.SaveChanges();
                return Redirect("/Admin/Index");
            }
            return View(orderDetail);
        }

        // GET: OrderDetails/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            OrderDetail orderDetail = _context.OrderDetails.Single(m => m.OrderDetailID == id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            OrderDetail orderDetail = _context.OrderDetails.Single(m => m.OrderDetailID == id);
            _context.OrderDetails.Remove(orderDetail);
            _context.SaveChanges();
            return Redirect("/Admin/Index");
        }
    }
}
