using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BO;

namespace EntityDal.EntityConfigurations
{
    public class TypeEquipementConfiguration : EntityTypeConfiguration<TypeEquipement>
    {
        public TypeEquipementConfiguration()
        {
            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
               Property(e => e.Libelle)
                .IsRequired()
                .HasMaxLength(40)
               .IsUnicode(false);

           
                HasMany(e => e.Modeles)
                .WithRequired(e => e.TypeEquipement)
                .WillCascadeOnDelete(false);
        }
    }
}
