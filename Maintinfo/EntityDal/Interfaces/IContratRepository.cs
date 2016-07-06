using System.Collections.Generic;
using BO;

namespace EntityDal.Interfaces
{
    public interface IContratRepository : IRepository<Contrat>
    {
        IEnumerable<Contrat> GetContratByClient(int idClient);



    }
}
