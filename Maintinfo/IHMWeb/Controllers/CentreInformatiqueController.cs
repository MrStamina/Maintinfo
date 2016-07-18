using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BO;
using BusinessLogicLayer;
using IHMWeb.ViewModels;

namespace IHMWeb.Controllers
{
    public class CentreInformatiqueController : Controller
    {
        private GestionnaireContrat gesContrat;

        public CentreInformatiqueController()
        {
            gesContrat= new GestionnaireContrat();
        }

        [HttpPost]
        public ActionResult Register(CentreInformatiqueFormViewModel centreInformatiqueFormView)
        {
            int idCentre = 0;
            if (!ModelState.IsValid)
            {
                var viewModel = new CentreInformatiqueFormViewModel
                {
                    Clients = gesContrat.GetAllClients(),
                    Secteurs = gesContrat.GetAllSecteurs()
                };
                return View("CentreInformatiqueForm", viewModel);
            }
            else
            {
                if (centreInformatiqueFormView.ClientId != null)
                {
                    CentreInformatique centre = new CentreInformatique
                    {
                        ClientId = (int) centreInformatiqueFormView.ClientId,
                        SecteurId = centreInformatiqueFormView.SecteurId,
                        AdresseCentre = centreInformatiqueFormView.AdresseCentre,
                        TelCentre = centreInformatiqueFormView.TelCentre,
                        VilleCentre = centreInformatiqueFormView.VilleCentre
                    };
                    gesContrat.AddCentre(centre);
                    gesContrat.ValiderChangementCentre();
                    idCentre = centre.Id;

                }
                
            }
            return RedirectToAction("Config", new { id = idCentre });

        }

        public ActionResult Details(int id)
        {
            var client = gesContrat.GetClient(id);
            var centreInformatiques = gesContrat.GetCentreByClient(id);
            var viewModel = new ContratViewModel
            {
                Client = client,
                CentreInformatiques = centreInformatiques
            };

            return View("Details", viewModel);
        }


        public ActionResult Config(int id)
        {
            
            var modeles = gesContrat.GetAllModeles();
            var ligneEquipement = gesContrat.AfficherEquipements(id);
            var viewModel = new EquipementFormViewModel
            {
                Quantite = null,
                LigneEquipements = ligneEquipement,
                CentreInformatiqueId = id,
                Modeles = modeles,
                
            };
            
            return View("Configuration", viewModel);
        }
        [HttpPost]
        public ActionResult Save(EquipementFormViewModel equipement)
        {
            List<Equipement> equipements = new List<Equipement>();
            for (int i = 1; i <= equipement.Quantite; i++)
            {
                Equipement equip = new Equipement
                {
                    ModeleId = equipement.ModeleId,
                    CentreInformatiqueId = equipement.CentreInformatiqueId

                };
                equipements.Add(equip);
            }

            gesContrat.AddRangeEquipement(equipements);
            gesContrat.ValiderChangementEquipement();

            ModelState.Clear();
            var viewModel = new EquipementFormViewModel
            {
                Modeles = gesContrat.GetAllModeles(),
                CentreInformatiqueId = equipement.CentreInformatiqueId,
                Quantite = null,
                LigneEquipements = gesContrat.AfficherEquipements(equipement.CentreInformatiqueId)
            };
            return View("Configuration", viewModel);

        }


        public ActionResult New(int? id)
        {
            var viewModel = new CentreInformatiqueFormViewModel
            {
                ClientId = id ?? null,
                Clients = gesContrat.GetAllClients(),
                Secteurs = gesContrat.GetAllSecteurs()
            };
            return View("CentreInformatiqueForm", viewModel);
        }
    }
}