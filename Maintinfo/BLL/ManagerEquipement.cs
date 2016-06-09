using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class ManagerEquipement
    {

        private DalEquipement dalEquip;
        private List<Equipement> listEquip;
        private ManagerLigneEquipement manLigne;

        public ManagerEquipement()
        {
            listEquip = new List<Equipement>();
            manLigne = new ManagerLigneEquipement();
            dalEquip = new DalEquipement();
        }
        public List<LigneEquipement> AfficherEquipementParCentre(List<Equipement> listEquip)
        {
                       
            return manLigne.TrierListe(listEquip);
        }

        public List<Equipement> ChargerEquipementParCentre(int idCentre)
        {
            return dalEquip.GetEquipementByCentre(idCentre);
        }

       

        public void AjouterEquipementAuContrat(List<Equipement> listEquip2, int numContrat)
        {
                        
            foreach(Equipement eq in listEquip2)
            {
                dalEquip.UpdEquipement(eq.NumeroSerie, numContrat);
            }
        }

        public List<Equipement> RetirerEquipementDuContrat(List<Equipement> listEquip,LigneEquipement ligneEquip)
        {

            listEquip.RemoveAll(x => x.Modele.LibelleModele == ligneEquip.Libelle_Modele);
            return listEquip;
            
        }
    }
}
