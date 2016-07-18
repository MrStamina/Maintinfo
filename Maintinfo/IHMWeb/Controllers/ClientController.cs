using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using AutoMapper;
using BO;
using BusinessLogicLayer;
using IHMWeb.ViewModels;

namespace IHMWeb.Controllers
{
    public class ClientController : Controller
    {
        private GestionnaireContrat gesContrat;
        // GET: Client

        public ClientController()
        {
            gesContrat = new GestionnaireContrat();
        }
        public ActionResult Index()
        {
            var lesClients = gesContrat.GetAllClients();
            return View(lesClients);
        }

        public ActionResult Edit(int id)
        {
            var client = gesContrat.GetClient(id);
            if (client == null)
                return HttpNotFound();

            var viewModel = new ClientFormViewModel(client)
            {
                Contrats = gesContrat.GetContratByClient(id),
                CentreInformatiques = gesContrat.GetCentreByClient(id)
            };

            return View("ClientForm", viewModel);

        }

        public ActionResult New()
        {
            var viewModel = new ClientFormViewModel();
            return View("ClientForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Client client)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ClientFormViewModel(client)
                {
                    CentreInformatiques = gesContrat.GetCentreByClient(client.Id),
                    Contrats = gesContrat.GetContratByClient(client.Id)
                };

                return View("ClientForm", viewModel);
            }

            if (client.Id == 0)
            {
                gesContrat.AddClient(client);
            }
            else
            {
                var clientInDb = gesContrat.GetClient(client.Id);
                clientInDb.NomClient = client.NomClient;
                clientInDb.Adresse = client.Adresse;
                clientInDb.Ville = client.Ville;
                clientInDb.CodePostal = client.CodePostal;
                clientInDb.Telephone = client.Telephone;

            }
            gesContrat.ValiderChangementClient();
            if ((int) Session["Centre"] == 1)
            {
                return RedirectToAction("New", "CentreInformatique");
                
            }
            Session["Centre"] = null;
            return RedirectToAction("Index", "Client");
           
        }
    }
}