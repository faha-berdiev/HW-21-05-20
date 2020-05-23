﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Task.Controllers
{
    public class HomeController : Controller
    {        
        public HomeController() { }

        public IActionResult Index()
        {
            return View(PersonContext.Read());
        }
    }
}
