﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PharmacyLTM.BackendAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyLTM.BackendAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Ok();
        }
    }
}
