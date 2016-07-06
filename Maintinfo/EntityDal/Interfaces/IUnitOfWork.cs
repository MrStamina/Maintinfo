using System;

namespace EntityDal.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IContratRepository Contrats { get; set; }
        IClientRepository Clients { get; set; }

        ICentreInformatiqueRepository CentreInformatiques { get; set; }
        int Complete();
    }
}
