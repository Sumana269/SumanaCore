﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SumanaCore.Controllers
{
    public class GuruController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
