using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteProject.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Generalelements()
        {
            return View();
        }
        public ActionResult Advancedelements()
        {
            return View();
        }
        public ActionResult Editors()
        {
            return View();
        }
        public ActionResult Validation()
        {
            return View();
        }
    }
}