using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using D05.Models;

namespace D05.Controllers
{
    public class Planyourvisit : Controller
    {
        private ApplicationDbContext _context;

        public Planyourvisit(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult PlanYourVisit(string tab)
        {
            
            ViewData["Key"] = tab;
            return View(_context.Events.ToList());
        }




    }
}
