namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MODELE")]
    public partial class MODELE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MODELE()
        {
            EQUIPEMENT = new HashSet<EQUIPEMENT>();
        }

        [Key]
        public int IDMODELE { get; set; }

        public int IDTYPE { get; set; }

        public int CODETARIF { get; set; }

        [Required]
        [StringLength(40)]
        public string LIBELLEMODELE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQUIPEMENT> EQUIPEMENT { get; set; }

        public virtual TYPE_EQUIPEMENT TYPE_EQUIPEMENT { get; set; }

        public virtual TARIF TARIF { get; set; }
    }
}
