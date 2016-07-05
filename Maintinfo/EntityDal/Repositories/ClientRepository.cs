using BLL;
using BO;

namespace EntityDal.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(MaintinfoContext context) : base(context)
        {
        }

        public MaintinfoContext MaintinfoContext
        {
            get { return Context as MaintinfoContext; }
        }
    }
}
