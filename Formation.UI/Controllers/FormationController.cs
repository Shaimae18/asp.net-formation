using Formation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formation.UI.Controllers
{
    public class FormationController : Controller
    {
        // GET: Formation
        private AvisFormationEntities dbFormations = new AvisFormationEntities();

        public ActionResult Index()
        {
            var lstFormations = dbFormations.Formation.ToList().OrderBy(f=> f.Nom);
            return View(lstFormations);
        }
    }
}