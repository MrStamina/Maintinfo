using System.Collections.Generic;
using BO;

namespace EntityDal.Interfaces
{
    public interface ICentreInformatiqueRepository : IRepository<CentreInformatique>
    {
       IEnumerable<CentreInformatique> GetCentreByClient(int idClient);
    }
}
