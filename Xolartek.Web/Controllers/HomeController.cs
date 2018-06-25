using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xolartek.Domain;
using Xolartek.Entities;
using Xolartek.Web.XolarService;

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
            List<Material> result = db.Materials.ToList();
            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            XolarServiceClient service = new XolarServiceClient();
            List<Material> result = service.GetMaterials();

            return View(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}