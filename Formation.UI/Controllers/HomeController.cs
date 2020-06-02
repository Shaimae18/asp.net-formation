using Formation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formation.UI.Controllers
{
    public class HomeController : Controller
    {
        private AvisFormationEntities dbFormations = new AvisFormationEntities();
        public ActionResult Index()
        {
        //    Random rand = new Random();
            var lstFormations = dbFormations.Formation.OrderBy(emp => Guid.NewGuid()).ToList().Take(4);
            return View(lstFormations);
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
    }
}