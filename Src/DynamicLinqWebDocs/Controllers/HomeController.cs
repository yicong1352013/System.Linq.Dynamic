﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicLinqWebDocs.Controllers
{
    public class HomeController : Controller
    {
        [Route]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Info")]
        public ActionResult Info()
        {
            return View();
        }
    }
}