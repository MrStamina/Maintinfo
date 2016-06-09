using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
   public class ManagerLigneEquipement
    {
        public ManagerLigneEquipement()
        {

        }

        // Méthode pour trier la liste d'équipements du centre afin de les afficher par modèle
        // et quantité.
        public List<LigneEquipement> TrierListe(List<Equipement> listEquip)
        {
            List<LigneEquipement> listLigne = new List<LigneEquipement>();
            List<Equipement> listTriage;
            int quantite;
            string libelle;
            double tarif;
            for (int i = 1; i <= 5; i++)
            {
                listTriage = new List<Equipement>();
                listTriage = listEquip.FindAll(x => x.Modele.IdModele == i);
                quantite = listTriage.Count;
                if (quantite != 0)
                {
                    Equipement e = listTriage.First();
                    libelle = e.Modele.LibelleModele;
                    tarif = (e.Modele.Tarif.TarifModele) * quantite;
                    LigneEquipement equip = new LigneEquipement(quantite, libelle, tarif);
                    listLigne.Add(equip);
                }

            }

            return listLigne;
        }

        
           
       
    }
}
