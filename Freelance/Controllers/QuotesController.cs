﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance.Controllers
{
    public class QuotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
