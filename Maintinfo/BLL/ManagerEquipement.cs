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
        List<Equipement> listEquip;
        private ManagerLigneEquipement manLigne;

        public ManagerEquipement()
        {
            listEquip = new List<Equipement>();
            manLigne = new ManagerLigneEquipement();
        }
        public List<LigneEquipement> AfficherEquipementParCentre(int idCentre)
        {
            dalEquip = new DalEquipement();
            listEquip = dalEquip.GetEquipementByCentre(idCentre);
            return manLigne.TrierListe(listEquip);
        }

        public void AjouterEquipementAuContrat(List<Equipement> listEquip,int numContrat)
        {
            
            dalEquip = new DalEquipement();
            foreach(Equipement eq in listEquip)
            {
                dalEquip.UpdEquipement(eq.NumeroSerie, numContrat);
            }
        }
    }
}
