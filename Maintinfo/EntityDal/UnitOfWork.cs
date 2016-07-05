using BLL;
using EntityDal.Repositories;

namespace EntityDal
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MaintinfoContext _context;
        public void Dispose()
        {
            _context.Dispose();
        }

        public UnitOfWork(MaintinfoContext context)
        {
            _context = context;
            Contrats = new ContratRepository(_context);
            Clients = new ClientRepository(_context);
            CentreInformatiques = new CentreInformatiqueRepository(_context);
        }

        public IContratRepository Contrats { get; set; }
        public IClientRepository Clients { get; set; }
        public ICentreInformatiqueRepository CentreInformatiques { get; set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
