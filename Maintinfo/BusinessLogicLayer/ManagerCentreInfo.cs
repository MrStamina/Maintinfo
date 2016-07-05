using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using EntityDal;

namespace BusinessLogicLayer
{
    public class ManagerCentreInfo
    {
        private UnitOfWork unitOfWork;
        private MaintinfoContext _context;

        public ManagerCentreInfo()
        {
            _context = new MaintinfoContext();
            unitOfWork = new UnitOfWork(_context);
        }

        

        public IEnumerable<CentreInformatique> GetAllCentreInformatiques()
        {
            return unitOfWork.CentreInformatiques.GetAll();
        }

        public IEnumerable<CentreInformatique> GetCentreByClient(int idClient)
        {
            return unitOfWork.CentreInformatiques.GetCentreByClient(idClient);
        }
        // CentrebyClient
    }
}
