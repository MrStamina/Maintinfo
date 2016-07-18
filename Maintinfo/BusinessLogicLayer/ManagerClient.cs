using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using EntityDal;

namespace BusinessLogicLayer
{
    public class ManagerClient
    {
        private UnitOfWork unitOfWork;
        private MaintinfoContext _context;

        public ManagerClient()
        {
            _context = new MaintinfoContext();
            unitOfWork = new UnitOfWork(_context);
        }

        public IEnumerable<Client> GetAllClients()
        {
            return unitOfWork.Clients.GetAll();
           
        }

        public Client GetClient(int idClient)
        {
            return unitOfWork.Clients.Get(idClient);

        }

        public void AddClient(Client client)
        {
            unitOfWork.Clients.Add(client);
            unitOfWork.Complete();
        }

        public void RemoveClient(Client client)
        {
            unitOfWork.Clients.Remove(client);
        }

        public int ValiderChangement()
        {
            return unitOfWork.Complete();
        }

        //Ajout Client
    }
}
