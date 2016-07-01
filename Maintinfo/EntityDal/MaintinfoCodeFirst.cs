using EntityDal.EntityConfigurations;

namespace EntityDal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MaintinfoCodeFirst : DbContext
    {
        public MaintinfoCodeFirst()
            : base("name=EntityDal.Properties.Settings.MaintinfoCodeFirst")
        {
        }

        public virtual DbSet<CentreInformatique> CentreInformatiques { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
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












        }
    }
}
