using BO;
using EntityDal.Interfaces;

namespace EntityDal.Repositories
{
    public class ModeleRepository : Repository<Modele>, IModeleRepository  
    {
        public ModeleRepository(MaintinfoContext context) : base(context)
        {
        }
    }
}
