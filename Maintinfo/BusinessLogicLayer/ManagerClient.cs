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

        //Ajout Client
    }
}
