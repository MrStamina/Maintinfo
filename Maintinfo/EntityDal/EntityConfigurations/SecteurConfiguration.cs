﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDal.EntityConfigurations
{
    public class SecteurConfiguration : EntityTypeConfiguration<Secteur>
    {
        public SecteurConfiguration()
        {
            Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(e => e.Libelle)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

           
                HasMany(e => e.CentreInformatiques)
                .WithRequired(e => e.Secteur)
                .WillCascadeOnDelete(false);
        }
    }
}
