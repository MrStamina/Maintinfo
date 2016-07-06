using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;
using IHMWeb.ViewModels;

namespace IHMWeb.Controllers
{
    public class ContratController : Controller
    {
        // GET: Contrat

        private GestionnaireContrat gesContrat;

        public ContratController()
        {
            gesContrat = new GestionnaireContrat();
        }
        public ActionResult Index()
        {
            var lesContrats = gesContrat.GetAllContrats();
            var lesClients = gesContrat.GetAllClients();
            var viewModel = new ContratViewModel
            {
                Clients = lesClients,
                Contrats = lesContrats,
            };
            return View(viewModel);
        }
    }
}