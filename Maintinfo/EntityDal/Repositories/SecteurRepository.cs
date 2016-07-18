using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using EntityDal.Interfaces;

namespace EntityDal.Repositories
{
    public class SecteurRepository : Repository<Secteur>, ISecteurRepository 
    {
        public SecteurRepository(MaintinfoContext context) : base(context)
        {
        }
    }
}
