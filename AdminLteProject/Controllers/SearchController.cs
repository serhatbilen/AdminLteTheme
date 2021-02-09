using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteProject.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Simplesearch()
        {
            return View();
        }
        public ActionResult Simpleresult()
        {
            return View();
        }
        public ActionResult Enhanced()
        {
            return View();
        }
        public ActionResult Enhancedresult()
        {
            return View();
        }
    }
}