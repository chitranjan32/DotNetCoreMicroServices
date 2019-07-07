﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Actio.API.Controllers
{

    [Route("")]
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Get() => Content("Hello from Actio API...");

    }
}