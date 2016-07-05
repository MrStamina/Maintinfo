﻿using System.Collections.Generic;
using System.Linq;
using BLL;
using BO;

namespace EntityDal.Repositories
{
    public class CentreInformatiqueRepository : Repository<CentreInformatique>, ICentreInformatiqueRepository
    {
        public MaintinfoContext MaintinfoContext
        {
            get { return Context as MaintinfoContext; }
        }

        public CentreInformatiqueRepository(MaintinfoContext context) : base(context)
        {
        }

        public IEnumerable<CentreInformatique> GetCentreByClient(int idClient)
        {
            var centreWithContrat = MaintinfoContext.CentreInformatiques
                .Where(c => c.ClientId == idClient)
                .OrderBy(c => c.VilleCentre);

            return centreWithContrat;
        }
    }
}
