using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteProject.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Layout
        public ActionResult Topnavigation()
        {
            return View();
        }
        public ActionResult Topnavigationsidebar()
        {
            return View();
        }
        public ActionResult Boxed()
        {
            return View();
        }
        public ActionResult Fixedsidebar()
        {
            return View();
        }
        public ActionResult Fixedsidebarcustom()
        {
            return View();
        }
        public ActionResult Fixednavbar()
        {
            return View();
        }
        public ActionResult Fixedfooter()
        {
            return View();
        }
        public ActionResult Collapsedsidebar()
        {
            return View();
        }
    }
}