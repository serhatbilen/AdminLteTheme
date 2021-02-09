using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteProject.Controllers
{
    public class TablesController : Controller
    {
        // GET: Tables
        public ActionResult Simple()
        {
            return View();
        }
        public ActionResult Data()
        {
            return View();
        }
        public ActionResult Jsgrid()
        {
            return View();
        }
    }
}