﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodWebsite.Controllers
{
    public class BlogGridController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
