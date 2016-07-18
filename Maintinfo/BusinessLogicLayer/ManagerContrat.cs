using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using EntityDal;

namespace BusinessLogicLayer
{
    public class ManagerContrat
    {
        private UnitOfWork unitOfWork;
        private MaintinfoContext _context;

        public ManagerContrat()
        {
            _context = new MaintinfoContext();
            unitOfWork = new UnitOfWork(_context);
        }

        public IEnumerable<Contrat> GetAllContrats()
        {
            return unitOfWork.Contrats.GetAll();
        }

        public IEnumerable<Contrat> GetContratByClient(int idClient)
        {
            return unitOfWork.Contrats.GetContratByClient(idClient);
                
        }

        public void AddContrat(Contrat contrat)
        {
            unitOfWork.Contrats.Add(contrat);
            
        }

        public int ValiderChangement()
        {
            return unitOfWork.Complete();
        }



    }
}
