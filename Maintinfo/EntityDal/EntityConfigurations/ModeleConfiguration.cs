using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BO;

namespace EntityDal.EntityConfigurations
{
    public class ModeleConfiguration : EntityTypeConfiguration<Modele>
    {
        public ModeleConfiguration()
        {
            Property(m => m.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
                Property(e => e.Libelle)
                .HasMaxLength(40)
                .IsRequired()
                .IsUnicode(false);

            
                HasMany(e => e.Equipements)
                .WithRequired(e => e.Modele)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Tarif)
                .WithRequiredPrincipal(c => c.Modele);
        }
    }
}
