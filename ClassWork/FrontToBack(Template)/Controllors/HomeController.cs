using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack_Template_.Controllors
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["numbers"] = new int[] {1,2,3,4,5,6,7,8,9 };
            ViewBag.nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return View();
        }
    }
}
