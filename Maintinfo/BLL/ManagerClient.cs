using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class ManagerClient
    {
       private ClientDal clientDal;
        private List<Client> listClient;

        public ManagerClient()
        {
            listClient = new List<Client>();
        }
        public List<Client> ChargerClient()
        {
            clientDal = new ClientDal();
            listClient = clientDal.GetAllClient();
            return listClient;
        }

        public int AjouterClient(Client client)
        {
            return clientDal.addClient(client);
            //ajouter à la liste ou recharger ?
        }


    }
}
