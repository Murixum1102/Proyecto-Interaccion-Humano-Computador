﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ihc.Controllers
{
    public class GerenciaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}