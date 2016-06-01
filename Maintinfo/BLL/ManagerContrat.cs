using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
namespace BLL
{
    public class ManagerContrat
    {

        private double tva = 0.2;

        public double calculerMontantHt(List<Equipement> listequip)
        {
            double montantHt = 0;
            listequip = new List<Equipement>();
            foreach(Equipement equip in listequip)
            {

                
                montantHt += equip.Tarif.TarifModele;
            }
            return montantHt;        
             

            
        }

        public bool addContrat(Contrat contrat)
        {
          
            return true;
        }

        public bool updContrat(Contrat contrat)
        {
            return true;
        }

        public double calculerMontantTtc(double montantHt)
        {
            return (montantHt + (montantHt * tva));
        }
    }
}
