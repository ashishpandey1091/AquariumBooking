using D05.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D05.Controllers
{
    public class ExhibitsController : Controller
    {
        private ApplicationDbContext _context;

        public ExhibitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Exhibits(String tab)
        {
            ViewData["key"] = tab;
            return View(_context.Events.ToList());
        }

        //public IActionResult Jounery()
        //{
        //    ViewData["key"] = "journey";  
        //    return View();
        //}

        //public IActionResult Dolphin()
        //{
        //    ViewData["key"] = "dolphin";
        //    return View();
        //}

        //public IActionResult SeaWorld()
        //{
        //    ViewData["key"] = "seaWorld";
        //    return View();
        //}
    }
}
