namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECTEUR")]
    public partial class SECTEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECTEUR()
        {
            CENTRE_INFORMATIQUE = new HashSet<CENTRE_INFORMATIQUE>();
        }

        [Key]
        public int IDSECTEUR { get; set; }

        [Required]
        [StringLength(40)]
        public string LIBELLESECTEUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CENTRE_INFORMATIQUE> CENTRE_INFORMATIQUE { get; set; }
    }
}
