using System.Collections.Generic;
using BO;

namespace BLL
{
    public interface ICentreInformatiqueRepository : IRepository<CentreInformatique>
    {
        IEnumerable<CentreInformatique> GetCentreByClient(int idClient);
    }
}
