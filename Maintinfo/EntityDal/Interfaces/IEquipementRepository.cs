using System.Collections.Generic;
using BO;

namespace EntityDal.Interfaces
{
    public interface IEquipementRepository : IRepository<Equipement>
    {
        IEnumerable<Equipement> GetEquipementByCentre(int idCentre);

        //void AddSomeEquipementsToContrat(IEnumerable<Equipement> lesEquipements , int idCentre, int idContrat);
    }
}
