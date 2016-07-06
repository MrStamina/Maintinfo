using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using EntityDal;

namespace BusinessLogicLayer
{
    public class GestionnaireContrat
    {
        private ManagerClient manClient;
        private ManagerCentreInfo manCentre;
        private ManagerContrat manContrat;
       

        public GestionnaireContrat()
        {
            manClient = new ManagerClient();
            manCentre = new ManagerCentreInfo();
            manContrat = new ManagerContrat();
          
        }

        public int ValiderChangement()
        {
            return manClient.ValiderChangement();
        }

        #region Gestion Client
        public IEnumerable<Client> GetAllClients()
        {
            return manClient.GetAllClients();
        }

        public Client GetClient(int idClient)
        {
            return manClient.GetClient(idClient);
        }

        public void AddClient(Client client)
        {
            manClient.AddClient(client);
        }

        

        #endregion

        #region Gestion Centre Informatiques
        public IEnumerable<CentreInformatique> GetAllCentreInformatiques()
        {
            return manCentre.GetAllCentreInformatiques();
        }

        public IEnumerable<CentreInformatique> GetCentreByClient(int idClient)
        {
            return manCentre.GetCentreByClient(idClient);
        }
       
        #endregion

        #region Gestion Contrats
        public IEnumerable<Contrat> GetContratByClient(int idClient)
        {
            return manContrat.GetContratByClient(idClient);
        }

        public IEnumerable<Contrat> GetAllContrats()
        {
            return manContrat.GetAllContrats();
        }

        public void AddContrat(Contrat contrat)
        {
            manContrat.AddContrat(contrat);
        }
        #endregion



    }
}
