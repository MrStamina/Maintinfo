using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
