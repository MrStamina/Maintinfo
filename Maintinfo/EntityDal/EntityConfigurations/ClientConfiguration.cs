using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDal.EntityConfigurations
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.NomClient)
                .IsUnicode(false)
                .HasMaxLength(40)
                .IsRequired();


            Property(e => e.Adresse)
                .IsUnicode(false)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Ville)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();


            Property(e => e.CodePostal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsRequired();


            Property(e => e.Telephone)
                .IsUnicode(false)
                .HasMaxLength(12)
                .IsRequired();
            
                HasMany(e => e.CentreInformatiques)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            
                HasMany(e => e.Contrats)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);
        }
    }
}
