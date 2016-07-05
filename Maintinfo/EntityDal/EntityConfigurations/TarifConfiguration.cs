using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BO;

namespace EntityDal.EntityConfigurations
{
    public class TarifConfiguration : EntityTypeConfiguration<Tarif>
    {
        public TarifConfiguration()
        {

            Property(e => e.TarifModele)
                .HasPrecision(19, 4)
                .IsRequired()
                .HasColumnType("money");

            Property(t => t.DateTarif)
                .IsRequired();
            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
