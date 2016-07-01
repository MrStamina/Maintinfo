namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TYPE_EQUIPEMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TYPE_EQUIPEMENT()
        {
            MODELE = new HashSet<MODELE>();
        }

        [Key]
        public int IDTYPE { get; set; }

        [Required]
        [StringLength(30)]
        public string LIBELLETYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MODELE> MODELE { get; set; }
    }
}
