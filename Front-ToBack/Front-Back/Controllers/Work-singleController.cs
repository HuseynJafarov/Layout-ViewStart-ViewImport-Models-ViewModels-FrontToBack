﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_Back.Controllers
{
    public class Work_singleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
