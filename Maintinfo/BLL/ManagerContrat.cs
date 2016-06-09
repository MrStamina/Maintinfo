using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class ManagerContrat
    {

        private decimal tva = 0.2M;
        private decimal montantTtc;
        private List<Contrat> listeContrat;
        private DalContrat dalContrat;
       
        
        public ManagerContrat()
        {
            listeContrat = new List<Contrat>();
            
        }

        public List<Contrat> ChargerLesContrats()
        {
            dalContrat =  new DalContrat();
            listeContrat = dalContrat.GetAllContrat();
            return listeContrat;
        }
        public List<Contrat> ConsulterContratParClient(int idclient)
        {
            List<Contrat> listcont = listeContrat.FindAll(delegate (Contrat c) { return c.Client.NumClient == idclient; });
            return listcont;
        }

        public int EnregistrerContrat(Contrat contrat)
        {
            dalContrat = new DalContrat();
            return dalContrat.AddContrat(contrat);
           
        }

        public bool ModifierContrat(Contrat contrat)
        {
            return true;
        }

        public bool supprimerContrat(Contrat contrat)
        {
            return true;
        }

    // méthodes pour calculer automatiquement les montants du contrat en fonction des equipements
        public decimal CalculerMontantHt(List<LigneEquipement> listequip)
        {
            decimal montantHt = 0;
            foreach (LigneEquipement equip in listequip)
            {

                montantHt += equip.Tarif;
            }
            return montantHt;



        }
        public decimal CalculerMontantTtc(decimal montantHt)
        {
            
            montantTtc = (montantHt + (montantHt * tva));            
            return montantTtc;
        }

        public decimal AppliquerRemise(decimal remise)
        {
            if (remise != 0)
            {
                return montantTtc - (montantTtc * remise);
            }
            else
                return montantTtc;
        }

        public DateTime CalculerDateEcheance(DateTime datedebut)
        {
            return datedebut.AddYears(1);
        }
    }
}
