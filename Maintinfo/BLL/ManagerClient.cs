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
        ClientDal clientDal = new ClientDal();
        List<Client> listClient = new List<Client>();
        public List<Client> ChargerClient()
        {
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
