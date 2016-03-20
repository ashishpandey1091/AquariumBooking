using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D05.Controllers
{
    public class ExhibitsController : Controller
    {

        public IActionResult Exhibits(String tab)
        {
            ViewData["key"] = tab;
            return View();
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
