using System.Collections.Generic;
using System.Linq;
using BO;
using EntityDal.Interfaces;

namespace EntityDal.Repositories
{
    public class EquipementRepository : Repository<Equipement>, IEquipementRepository
    {
        public EquipementRepository(MaintinfoContext context) : base(context)
        {
        }
        public MaintinfoContext MaintinfoContext
        {
            get { return Context as MaintinfoContext; }
        }


        public IEnumerable<Equipement> GetEquipementByCentre(int idCentre)
        {
            var query = MaintinfoContext.Equipements
                .Where(e => e.CentreInformatique.Id == idCentre)
                .ToList();
            return query;
        }

        //public void AddSomeEquipementsToContrat(IEnumerable<Equipement> lesEquipements , int idCentre, int idContrat)
        //{
        //    var query = MaintinfoContext.Equipements
        //        .Where(c => c.CentreInformatiqueId == idCentre);

        //}
    }
}
