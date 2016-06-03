﻿using System;
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

        private double tva = 0.2;
        List<Contrat> listeContrat = new List<Contrat>();
        DalContrat dalContrat = new DalContrat();
        
        

        public List<Contrat> ChargerLesContrats()
        {
            listeContrat = dalContrat.GetAllContrat();
            return listeContrat;
        }
        public List<Contrat> ConsulterContratParClient(int idclient)
        {
            List<Contrat> listcont = listeContrat.FindAll(delegate (Contrat c) { return c.Client.NumClient == idclient; });
            return listcont;
        }

        public bool EnregistrerContrat(Contrat contrat)
        {
          
            return true;
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
        public double CalculerMontantHt(List<Equipement> listequip)
        {
            double montantHt = 0;
            foreach (Equipement equip in listequip)
            {

                montantHt += equip.Modele.Tarif.TarifModele;
            }
            return montantHt;



        }
        public double CalculerMontantTtc(double montantHt)
        {
            return (montantHt + (montantHt * tva));
        }
    }
}
