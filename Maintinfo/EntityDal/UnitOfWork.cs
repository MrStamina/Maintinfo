using EntityDal.Interfaces;
using EntityDal.Repositories;
using ICentreInformatiqueRepository = EntityDal.Interfaces.ICentreInformatiqueRepository;
using IClientRepository = EntityDal.Interfaces.IClientRepository;
using IContratRepository = EntityDal.Interfaces.IContratRepository;
using IUnitOfWork = EntityDal.Interfaces.IUnitOfWork;

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
            Modeles = new ModeleRepository(_context);
            Equipements = new EquipementRepository(_context);
            Secteurs = new SecteurRepository(_context);
            
        }
        public ISecteurRepository Secteurs { get; set; }
        public IContratRepository Contrats { get; set; }
        public IClientRepository Clients { get; set; }
        public ICentreInformatiqueRepository CentreInformatiques { get; set; }

        public IModeleRepository Modeles { get; set; }
        
        public IEquipementRepository Equipements { get; set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
