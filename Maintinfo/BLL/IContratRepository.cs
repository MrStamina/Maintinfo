using System.Collections.Generic;
using BO;

namespace BLL
{
    public interface IContratRepository : IRepository<Contrat>
    {
        IEnumerable<Contrat> GetContratByClient(int idClient);



    }
}
