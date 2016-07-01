using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDal.EntityConfigurations 
{
    public class ContratConfiguration : EntityTypeConfiguration<Contrat>
    {
        public ContratConfiguration()
        {
            //Api fluent
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.Montant)
                .HasPrecision(19, 2)
                .HasColumnType("money");



            Property(e => e.Commentaire)
                .IsUnicode(false)
                .HasMaxLength(100);
        }
    }
}
