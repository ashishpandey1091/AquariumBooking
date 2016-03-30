using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using D05.Models;

namespace D05.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Events.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View(_context.Events.ToList());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View(_context.Events.ToList());
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult FAQs()
        {
            return View(_context.Events.ToList());
        }

        public IActionResult Webpage1 ()
        {
            return View(_context.Events.ToList());
        }

        public IActionResult Webpage2 ()
        {
            return View(_context.Events.ToList());
        }

        public IActionResult Webpage3 ()
        {
            return View(_context.Events.ToList());
        }
    }
}
