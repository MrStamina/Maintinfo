using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using BO;
namespace BLL
{
    public class GestionnaireContrat
    {
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
            manEquip = new ManagerEquipement();
            manMod = new ManagerModele();
            manTar = new ManagerTarif();
        }

        public List<Client> ChargerClient()
        {
            return manClient.ChargerClient();
        }

        public List<CentreInformatique> ChargerCentre()
        {
            return manCentre.ChargerCentre();
        }

        public List<Contrat> ChargerContrat()
        {
            return manContrat.ChargerLesContrats();
        }

        public List<Contrat> ConsulterContratParClient(int idClient)
        {
           return manContrat.ConsulterContratParClient(idClient);
        }

        public List<CentreInformatique> AfficherCentreParClient (int idClient)
        {
            return manCentre.AfficherCentreParClient(idClient);
        }

        public List<LigneEquipement> AfficherEquipementParCentre(List<Equipement> listEquip)
        {
            return manEquip.AfficherEquipementParCentre(listEquip);
        }

        public List<Modele> ChargerModele()
        {
            return manMod.ChargerModele();
        }

        public List<Tarif> ChargerTarif()
        {
            return manTar.ChargerTarif();
        }

        public double CalculerMontantHt(List<LigneEquipement> listEquip)
        {
           return manContrat.CalculerMontantHt(listEquip);
        }

        public double CalculerMontantTtc(double montantht)
        {
            return manContrat.CalculerMontantTtc(montantht);
        }

        public DateTime CalculerDateEcheance(DateTime dateDebut)
        {
            return manContrat.CalculerDateEcheance(dateDebut);
        }

        public double AppliquerRemise(double remise)
        {
            return manContrat.AppliquerRemise(remise);
        }

        public int EnregistrerContrat(Contrat contrat)
        {
            return manContrat.EnregistrerContrat(contrat);
        }

        public void AjouterEquipementAuContrat(List<Equipement> listEquip2,int numcontrat)
        {
            manEquip.AjouterEquipementAuContrat(listEquip2,numcontrat);
        }

        public List<Equipement> RetirerEquipementDuContrat(List<Equipement> listEquip,LigneEquipement ligneEquip)
        {
            return manEquip.RetirerEquipementDuContrat(listEquip,ligneEquip);
        }

        public List<Equipement> ChargerEquipementParCentre(int numCentre)
        {
            return manEquip.ChargerEquipementParCentre(numCentre);
        }
    }
}
