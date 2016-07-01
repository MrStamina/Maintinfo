namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CENTRE_INFORMATIQUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CENTRE_INFORMATIQUE()
        {
            CONTRAT = new HashSet<CONTRAT>();
            EQUIPEMENT = new HashSet<EQUIPEMENT>();
        }

        [Key]
        public int NUMEROCENTRE { get; set; }

        public int IDSECTEUR { get; set; }

        public int NUMCLIENT { get; set; }

        [Required]
        [StringLength(100)]
        public string ADRESSECENTRE { get; set; }

        [Required]
        [StringLength(40)]
        public string VILLECENTRE { get; set; }

        [Required]
        [StringLength(12)]
        public string TELCENTRE { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        public virtual SECTEUR SECTEUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRAT> CONTRAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQUIPEMENT> EQUIPEMENT { get; set; }
    }
}
