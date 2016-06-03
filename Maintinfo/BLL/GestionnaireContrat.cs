using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
namespace BLL
{
    public class GestionnaireContrat
    {
        private ManagerContrat manContrat;
        private ManagerClient manClient;
        private ManagerCentreInformatique manCentre;
        private ManagerEquipement manEquip;

        public GestionnaireContrat()
        {
            manContrat = new ManagerContrat();
            manClient = new ManagerClient();
            manCentre = new ManagerCentreInformatique();
            manEquip = new ManagerEquipement();
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

        public List<Equipement> AfficherEquipementParCentre (int idCentre)
        {
            return manEquip.AfficherEquipementParCentre(idCentre);
        }
    }
}
