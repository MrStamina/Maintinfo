using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BO;

namespace EntityDal.EntityConfigurations
{
    public class EquipementConfiguration : EntityTypeConfiguration<Equipement>
    {
        public EquipementConfiguration()
        {
            Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.NumeroSerie)
                .HasMaxLength(12)
                .IsOptional();


        }
    }
}
