namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENT")]
    public partial class CLIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENT()
        {
            CENTRE_INFORMATIQUE = new HashSet<CENTRE_INFORMATIQUE>();
            CONTRAT = new HashSet<CONTRAT>();
        }

        [Key]
        public int NUMCLIENT { get; set; }

        [Required]
        [StringLength(40)]
        public string NOMCLIENT { get; set; }

        [Required]
        [StringLength(100)]
        public string ADRESSECLIENT { get; set; }

        [Required]
        [StringLength(40)]
        public string VILLECLIENT { get; set; }

        [Required]
        [StringLength(5)]
        public string CODEPOSTAL { get; set; }

        [Required]
        [StringLength(12)]
        public string TELCLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CENTRE_INFORMATIQUE> CENTRE_INFORMATIQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRAT> CONTRAT { get; set; }
    }
}
