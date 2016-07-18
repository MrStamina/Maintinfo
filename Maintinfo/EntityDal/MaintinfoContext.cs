using System.Data.Entity;
using BO;
using EntityDal.EntityConfigurations;

namespace EntityDal
{
    public class MaintinfoContext : DbContext
    {
        public MaintinfoContext()
            : base("name=EntityDal.Properties.Settings.MaintinfoContext")
        {
        }

        public virtual DbSet<CentreInformatique> CentreInformatiques { get; set; }
        public virtual  DbSet<Client> Clients { get; set; }
        public virtual DbSet<Contrat> Contrats { get; set; }
        public virtual DbSet<Equipement> Equipements { get; set; }
        public virtual DbSet<Modele> Modeles { get; set; }
        public virtual DbSet<Secteur> Secteurs { get; set; }
        public virtual DbSet<Tarif> Tarifs { get; set; }
        public virtual DbSet<TypeEquipement> TypeEquipements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ContratConfiguration());
            modelBuilder.Configurations.Add(new CentreInformatiqueConfiguration());
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new ModeleConfiguration());
            modelBuilder.Configurations.Add(new SecteurConfiguration());
            modelBuilder.Configurations.Add(new TarifConfiguration());
            modelBuilder.Configurations.Add(new TypeEquipementConfiguration());
            modelBuilder.Configurations.Add(new EquipementConfiguration());

            base.OnModelCreating(modelBuilder);

        }
    }
}
