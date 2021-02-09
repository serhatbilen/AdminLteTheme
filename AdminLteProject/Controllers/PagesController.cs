using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteProject.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Widgets()
        {
            return View();
        }
        public ActionResult Calendar()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Kanban()
        {
            return View();
        }
        public ActionResult iframe()
        {
            return View();
        }
    }
}