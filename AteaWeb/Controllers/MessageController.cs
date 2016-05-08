using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AteaWeb.Models;

namespace AteaWeb.Controllers
{
    public class MessageController : Controller
    {
        private Entities db = new Entities();

        // Hämta meddelanden ifrån db och sortera efter datum/tid.
        public ActionResult Index()
        {
            return View(db.MessageEntities.OrderBy(t => t.MessageTime).ToList());
        }

        // Stänger db-connection och ev. andra resurser.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
