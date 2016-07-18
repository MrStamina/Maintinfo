using System;

namespace EntityDal.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IContratRepository Contrats { get; set; }
        IClientRepository Clients { get; set; }

        ICentreInformatiqueRepository CentreInformatiques { get; set; }

        IModeleRepository Modeles { get; set; }

        IEquipementRepository Equipements { get; set; }
        int Complete();
    }
}
