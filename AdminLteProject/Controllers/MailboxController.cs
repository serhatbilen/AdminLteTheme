using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteProject.Controllers
{
    public class MailboxController : Controller
    {
        // GET: Mailbox
        public ActionResult Inbox()
        {
            return View();
        }
        public ActionResult Compose()
        {
            return View();
        }
        public ActionResult Read()
        {
            return View();
        }
    }
}