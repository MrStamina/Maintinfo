using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
//using BO;
using EntityDal;

namespace BLL
{
    public class GestionnaireContrat
    {
        //Le controleur s'occupe de gérer tous les managers

        private ManagerContrat manContrat;
        private ManagerClient manClient;
        private ManagerCentreInformatique manCentre;
        private ManagerEquipement manEquip;
        private ManagerModele manMod;
        private ManagerTarif manTar;

        public GestionnaireContrat()
        {
            manContrat = new ManagerContrat();
            manClient = new ManagerClient();
            manCentre = new ManagerCentreInformatique();
            //manEquip = new ManagerEquipement();
            //manMod = new ManagerModele();
            //manTar = new ManagerTarif();
        }

        //Chargement des données nécessaires au fonctionnement
        public IEnumerable<Client> ChargerClient()
        {
            return manClient.ChargerClient();
        }

        public IEnumerable<CentreInformatique> ChargerCentre()
        {
            return manCentre.ChargerCentre();
        }

        public IEnumerable<Contrat> ChargerContrat()
        {
            return manContrat.ChargerLesContrats();
        }
        //public List<Modele> ChargerModele()
        //{
        //    return manMod.ChargerModele();
        //}

        //public List<Tarif> ChargerTarif()
        //{
        //    return manTar.ChargerTarif();
        //}

        //Méthode pour afficher les contrats par client
        public IEnumerable<Contrat> ConsulterContratParClient(int idClient)
        {
           return manContrat.ConsulterContratParClient(idClient);
        }

        //Méthode pour afficher les Centres sans contrat par client
        //public List<CentreInformatique> AfficherCentreParClient(int idClient)
        //{
        //    List<CentreInformatique> listCentre = new List<CentreInformatique>();
        //    List<CentreInformatique> listCentr2 = new List<CentreInformatique>();
        //    List<Contrat> listContrat = new List<Contrat>();
        //    listContrat = manContrat.ChargerLesContrats();
        //    listContrat = manContrat.ConsulterContratParClient(idClient);
        //    listCentre = manCentre.AfficherCentreParClient(idClient);


        //    foreach (Contrat c in listContrat)
        //    {
        //        listCentr2.Add(new CentreInformatique() { NumCentre = c.CentreInfo.NumCentre });
        //    }

        //    var list3 = listCentre.Where(x => !listCentr2.Contains(x)).ToList();
        //    return list3;


        //}

        ////méthode qui gère l'affichage des équipements du centre retrier par Modèle
        //public List<LigneEquipement> AfficherEquipementParCentre(List<Equipement> listEquip)
        //{

        //    return manEquip.AfficherEquipementParCentre(listEquip);
        //}


        //// Méthodes pour calculer automatiquement les montants et la date d'échéance
        //public decimal CalculerMontantHt(List<LigneEquipement> listEquip)
        //{
        //   return manContrat.CalculerMontantHt(listEquip);
        //}

        //public decimal CalculerMontantTtc(decimal montantht)
        //{
        //    return manContrat.CalculerMontantTtc(montantht);
        //}

        //public DateTime CalculerDateEcheance(DateTime dateDebut)
        //{
        //    return manContrat.CalculerDateEcheance(dateDebut);
        //}

        ////Méthode qui applique une remise sur le montant Ttc
        //public decimal AppliquerRemise(decimal remise)
        //{
        //    return manContrat.AppliquerRemise(remise);
        //}

        ////Méthode qui gère l'enregistrement d'un contrat

        //public int EnregistrerContrat(Contrat contrat)
        //{
        //    return manContrat.EnregistrerContrat(contrat);
        //}

        ////Méthode qui ajoute les équipements du centre au contrat de maintenance
        //public void AjouterEquipementAuContrat(List<Equipement> listEquip2,int numcontrat)
        //{
        //    manEquip.AjouterEquipementAuContrat(listEquip2,numcontrat);
        //}

        ////Méthode qui permet de retirer des équipements dans le cas ou le contrat ne concerne pas
        //// tous les équipements du centre
        //public List<Equipement> RetirerEquipementDuContrat(List<Equipement> listEquip,LigneEquipement ligneEquip)
        //{
        //    return manEquip.RetirerEquipementDuContrat(listEquip,ligneEquip);
        //}

        ////Méthode qui charge tous les équipements d'un centre
        //public List<Equipement> ChargerEquipementParCentre(int numCentre)
        //{
        //    return manEquip.ChargerEquipementParCentre(numCentre);
        //}
    }
}
