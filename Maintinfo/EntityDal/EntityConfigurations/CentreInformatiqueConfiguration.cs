using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDal.EntityConfigurations
{
   public class CentreInformatiqueConfiguration : EntityTypeConfiguration<CentreInformatique>
    {
       public CentreInformatiqueConfiguration()
       {

           Property(e => e.AdresseCentre)
               .HasMaxLength(100)
               .IsUnicode(false)
               .IsRequired();

            
                Property(e => e.VilleCentre)
                .HasMaxLength(40)
                .IsRequired()
                .IsUnicode(false);

            
                Property(e => e.TelCentre)
                .HasMaxLength(12)
                .IsRequired()
                .IsUnicode(false);

           Property(c => c.Id)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            
                HasMany(e => e.Contrat)
                .WithRequired(e => e.CentreInformatique)
                .WillCascadeOnDelete(false);

            
                HasMany(e => e.Equipements)
                .WithRequired(e => e.CentreInformatique)
                .WillCascadeOnDelete(false);
        }
    }
}
