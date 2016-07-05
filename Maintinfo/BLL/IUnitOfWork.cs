using System;

namespace BLL
{
    public interface IUnitOfWork : IDisposable
    {
        IContratRepository Contrats { get; set; }
        IClientRepository Clients { get; set; }

        ICentreInformatiqueRepository CentreInformatiques { get; set; }
        int Complete();
    }
}
