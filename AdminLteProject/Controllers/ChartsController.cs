﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteProject.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult Chartsjs()
        {
            return View();
        }
        public ActionResult Flot()
        {
            return View();
        }
        public ActionResult Inline()
        {
            return View();
        }
        public ActionResult Uplot()
        {
            return View();
        }
    }
}