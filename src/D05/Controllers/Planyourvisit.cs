using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace D05.Controllers
{
    public class Planyourvisit : Controller
    {

        public IActionResult PlanYourVisit(string tab)
        {
            
            ViewData["Key"] = tab;
            return View();
        }

    }
}
