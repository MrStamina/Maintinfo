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
    public class ContratController : Controller
    {
        // GET: Contrat
        
        private GestionnaireContrat gesContrat;

        private List<LigneEquipement> LesLignesEquipements2
        {
            get { return Session["lesLignesEquipements2"] as List<LigneEquipement>; }
            set { Session["lesLignesEquipements2"] = value; }
        }

        private List<Equipement> LesEquipements
        {
            get { return Session["lesEquipements"] as List<Equipement>; }
            set { Session["lesEquipements"] = value; }
        }
      

        public ContratController()
        {
            
            gesContrat = new GestionnaireContrat();
            
        }
        //public ActionResult Index()
        //{
        //    //var lesContrats = gesContrat.GetAllContrats();
        //    //var lesClients = gesContrat.GetAllClients();
        //    //var viewModel = new ContratViewModel
        //    //{
        //    //    Client = lesClients,
        //    //    Contrats = lesContrats,
        //    //};
        //    //return View(viewModel);
        //}

        public ActionResult Details(int id)
        {
            var client = gesContrat.GetClient(id);
            var contrats = gesContrat.GetContratByClient(id);

            var viewModel = new ContratViewModel
            {
                Client = client,
                Contrats = contrats
            };

            return View("Details", viewModel);
        }
        //TODO Gerer retirer Equipements
        public ActionResult New(int idClient, int idCentre)
        {
           var lesLigneEquipements = gesContrat.AfficherEquipements(idCentre);
            decimal montantHt = gesContrat.CalculerMontantHt(lesLigneEquipements);
            decimal montantTtc = gesContrat.CalculerMontantTtc(montantHt);

            var viewModel = new ContratViewModel
            {
                ClientId = idClient,
                DateDebut = DateTime.Now,
                MontantHt = montantHt,
                MontantTtc = montantTtc,
                CentreInformatiqueId = idCentre,
                LigneEquipements = lesLigneEquipements
            };

            return View("ContratForm", viewModel);
        }
        //TODO Gestion contrat
        [HttpPost]

        public ActionResult Save(ContratViewModel contratViewModel)
        {

                if (contratViewModel.Id == 0)
                {
                    Contrat contrat = new Contrat
                    {
                        DateDebut = contratViewModel.DateDebut,
                        DateEcheance = contratViewModel.DateDebut.AddYears(1),
                        CentreInformatiqueId = contratViewModel.CentreInformatiqueId,
                        ClientId = contratViewModel.ClientId,
                        Commentaire = contratViewModel.Commentaire,
                        Montant = contratViewModel.MontantTtc,

                    };
                    gesContrat.AddContrat(contrat);
                    gesContrat.ValiderChangementContrat();
                    if ((int)Session["Count"] == 1)
                        gesContrat.AddEquipementToContrat(contratViewModel.CentreInformatiqueId, contrat.Id);
                    else
                    {
                        gesContrat.AddSomeEquipementsToContrat(LesEquipements, contratViewModel.CentreInformatiqueId, contrat.Id);
                    }

                    Session["Count"] = null;
                }

            
            
            return RedirectToAction("Index", "Client");
        }
        
     
        public ActionResult Remove(int count, string modele, int idClient, int idCentre)
        {
           
            if (count == 1)
            {
                List<LigneEquipement> lesLigneEquipements;
                var listeEquipement = gesContrat.AfficherEquipements(idCentre);
                lesLigneEquipements = listeEquipement;
                lesLigneEquipements = gesContrat.RetirerEquipements(lesLigneEquipements, modele, idCentre);
                LesLignesEquipements2 = lesLigneEquipements;
                var liste1 = gesContrat.GetEquipementsByCentre(idCentre).ToList();
                liste1.RemoveAll(p => p.Modele.Libelle == modele);
                LesEquipements = liste1;
               

                decimal montantHt = gesContrat.CalculerMontantHt(lesLigneEquipements);
                decimal montantTtc = gesContrat.CalculerMontantTtc(montantHt);
                var viewModel = new ContratViewModel
                {
                    ClientId = idClient,
                    DateDebut = DateTime.Now,
                    MontantHt = montantHt,
                    MontantTtc = montantTtc,
                    CentreInformatiqueId = idCentre,
                    LigneEquipements = lesLigneEquipements,
                   

                };

                return View("ContratForm", viewModel);
            }
            else
            {
                LesLignesEquipements2 = gesContrat.RetirerEquipements(LesLignesEquipements2, modele, idCentre);
                LesEquipements.RemoveAll(x => x.Modele.Libelle == modele);
                decimal montantHt = gesContrat.CalculerMontantHt(LesLignesEquipements2);
                decimal montantTtc = gesContrat.CalculerMontantTtc(montantHt);
                var viewModel = new ContratViewModel
                {
                    ClientId = idClient,
                    DateDebut = DateTime.Now,
                    MontantHt = montantHt,
                    MontantTtc = montantTtc,
                    CentreInformatiqueId = idCentre,
                    LigneEquipements = LesLignesEquipements2,

                };

                return View("ContratForm", viewModel);
            }
           



        }
    }
}