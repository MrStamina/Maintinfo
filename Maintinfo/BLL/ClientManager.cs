using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class ClientManager
    {
        ClientDal clientDal = new ClientDal();
        List<Client> listClient = new List<Client>();
        public List<Client> chargerClient()
        {
            listClient = clientDal.GetAllClient();
            return listClient;
        }

        public int ajouterClient(Client client)
        {
            return clientDal.addClient(client);
            //ajouter à la liste ou recharger ?
        }


    }
}
