using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using EntityDal;

namespace BusinessLogicLayer
{
    public class GestionnaireContrat
    {
        private ManagerClient manClient;
        private ManagerCentreInfo manCentre;
        private ManagerContrat manContrat;
        private ManagerEquipement manEquip;
        private ManagerModele manMod;
        private decimal tva = 0.2M;
       

        public GestionnaireContrat()
        {
            manClient = new ManagerClient();
            manCentre = new ManagerCentreInfo();
            manContrat = new ManagerContrat();
            manEquip = new ManagerEquipement();
            manMod = new ManagerModele();
          
        }
        #region Validation
        public int ValiderChangementClient()
        {
            return manClient.ValiderChangement();
        }

        public int ValiderChangementEquipement()
        {
            return manEquip.ValiderChangement();
        }

        public int ValiderChangementContrat()
        {
            return manContrat.ValiderChangement();
        }

        public int ValiderChangementCentre()
        {
            return manCentre.ValiderChangementCentre();
        }
        #endregion

        #region Gestion Client
        public IEnumerable<Client> GetAllClients()
        {
            return manClient.GetAllClients();
        }

        public Client GetClient(int idClient)
        {
            return manClient.GetClient(idClient);
        }

        public void AddClient(Client client)
        {
            manClient.AddClient(client);
        }

        public void RemoveClient(Client client)
        {
            manClient.RemoveClient(client);
        }

        

        #endregion

        #region Gestion Centre Informatiques
        public IEnumerable<CentreInformatique> GetAllCentreInformatiques()
        {
            return manCentre.GetAllCentreInformatiques();
        }

        public IEnumerable<CentreInformatique> GetCentreByClient(int idClient)
        {
            return manCentre.GetCentreByClient(idClient);
        }

        public void AddCentre(CentreInformatique centre)
        {
            manCentre.AddCentre(centre);
        }
      
       
        #endregion

        #region Gestion Contrats
        public IEnumerable<Contrat> GetContratByClient(int idClient)
        {
            return manContrat.GetContratByClient(idClient);
        }

        public IEnumerable<Contrat> GetAllContrats()
        {
            return manContrat.GetAllContrats();
        }

        public void AddContrat(Contrat contrat)
        {
            manContrat.AddContrat(contrat);
        }

        public decimal CalculerMontantHt(List<LigneEquipement> ligneEquipements)
        {
            decimal montantHt = 0;
            foreach (var ligneEquip in ligneEquipements)
            {
                montantHt += ligneEquip.Montant;
            }
            return montantHt;
        }

        public decimal CalculerMontantTtc(decimal montant)
        {
            
            return montant + (montant*tva);
        }
        #endregion

        #region Gestion Equipements

        public void AddEquipement(Equipement equipement)
        {
            manEquip.AddEquipement(equipement);
        }

        public void AddRangeEquipement(IEnumerable<Equipement> equipements)
        {
            manEquip.AddRangeEquipement(equipements);
        }

        public List<LigneEquipement> AfficherEquipements(int idCentre)
        {
            return manEquip.AfficherEquipements(idCentre);
        }

        public void AddEquipementToContrat(int idCentre, int idContrat)
        {
             manEquip.AddEquipementToContrat(idCentre,idContrat);
        }

        public void AddSomeEquipementsToContrat(IEnumerable<Equipement> lesEquipements, int idCentre, int idContr)
        {
            manEquip.AddSomeEquipementToContrat(lesEquipements,idCentre,idContr);
        }

        public List<LigneEquipement> RetirerEquipements(List<LigneEquipement> lesEquipements, string modele, int idCentre)
        {
            return manEquip.RetirerEquipements(lesEquipements,modele, idCentre);
        }

        public IEnumerable<Equipement> GetEquipementsByCentre(int idCentre)
        {
            return manEquip.GetEquipementsByCentre(idCentre);
        }

        #endregion

        #region Gestion Modeles

        public IEnumerable<Modele> GetAllModeles()
        {
            return manMod.GetAllModeles();
        }
        #endregion
        #region Gestion Secteurs

        public IEnumerable<Secteur> GetAllSecteurs()
        {
            return manMod.GetAllSecteurs();
        }
        #endregion
    }
}
