using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xolartek.Domain;
using Xolartek.Entities;

namespace Xolartek.Web.Controllers
{
    public class HomeController : Controller
    {
        private XolarDatabase db;

        public HomeController() : base()
        {
            db = new XolarDatabase();
        }
        public ActionResult Index()
        {
            List<Schematic> result = db.Schematics.ToList();
            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}