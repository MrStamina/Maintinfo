using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;

namespace IHMWeb.Controllers
{
    public class EquipementController : Controller
    {
        private GestionnaireContrat gesContrat;

        public EquipementController()
        {
            gesContrat = new GestionnaireContrat();
        }
        // GET: Equipement
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Config(int id)
        {
            return View();
        }
    }
}