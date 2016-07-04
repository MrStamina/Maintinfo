using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BO;
//using DAL;
using EntityDal;

namespace BLL
{
    public class ManagerClient
    {
        //private ClientDal clientDal;
        //private List<Client> listClient;
        private MaintinfoContext context;

        public ManagerClient()
        {
            //listClient = new List<Client>();
            context = new MaintinfoContext();
        }
        public IEnumerable<Client> ChargerClient()
        {
            
            
            var lesClients = context.Clients.ToList();
            return lesClients;


        }

        //public int AjouterClient(Client client)
        //{
        //    return clientDal.addClient(client);
        //    //ajouter à la liste ou recharger ?
        //}


    }
}
