﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTester.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View(new Models.BootstrapSampleObject());
        }

        public ActionResult Index2()
        {
            return View(new Models.BootstrapSampleObject());
        }
    }
}