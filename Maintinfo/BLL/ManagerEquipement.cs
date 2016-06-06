﻿using System;
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

        DalEquipement dalEquip;
        List<Equipement> listEquip;

        public ManagerEquipement()
        {
            listEquip = new List<Equipement>();
        }
        public List<Equipement> AfficherEquipementParCentre(int idCentre)
        {
            dalEquip = new DalEquipement();
            return listEquip = dalEquip.GetEquipementByCentre(idCentre);
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
