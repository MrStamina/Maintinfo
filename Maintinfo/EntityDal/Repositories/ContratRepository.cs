﻿using System.Collections.Generic;
using System.Linq;
using BLL;
using BO;

namespace EntityDal.Repositories
{
    public class ContratRepository : Repository<Contrat>, IContratRepository
    {
        public ContratRepository(MaintinfoContext context) : base(context)
        {
        }

        public MaintinfoContext MaintinfoContext
        {
            get { return Context as MaintinfoContext;}
        }

        public IEnumerable<Contrat> GetContratByClient(int idClient)
        {
            var contratByClient = MaintinfoContext.Contrats
                .Where(c => c.ClientId.Equals(idClient))
                .OrderBy(c => c.CentreInformatique.VilleCentre)
                .ToList();
            return contratByClient;
        }
    }
}
