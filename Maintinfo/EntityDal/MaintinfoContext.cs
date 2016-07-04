using EntityDal.EntityConfigurations;

namespace EntityDal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class MaintinfoContext : DbContext
    {
        public MaintinfoContext()
            : base("name=EntityDal.Properties.Settings.MaintinfoContext")
        {
        }

        public  DbSet<CentreInformatique> CentreInformatiques { get; set; }
        public  DbSet<Client> Clients { get; set; }
        public  DbSet<Contrat> Contrats { get; set; }
        public  DbSet<Equipement> Equipements { get; set; }
        public  DbSet<Modele> Modeles { get; set; }
        public  DbSet<Secteur> Secteurs { get; set; }
        public  DbSet<Tarif> Tarifs { get; set; }
        public  DbSet<TypeEquipement> TypeEquipements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ContratConfiguration());
            modelBuilder.Configurations.Add(new CentreInformatiqueConfiguration());
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new ModeleConfiguration());
            modelBuilder.Configurations.Add(new SecteurConfiguration());
            modelBuilder.Configurations.Add(new TarifConfiguration());
            modelBuilder.Configurations.Add(new TypeEquipementConfiguration());

            base.OnModelCreating(modelBuilder);

        }
    }
}
