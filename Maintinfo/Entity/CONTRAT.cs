namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTRAT")]
    public partial class CONTRAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRAT()
        {
            EQUIPEMENT = new HashSet<EQUIPEMENT>();
        }

        [Key]
        public int NUMCONTRAT { get; set; }

        public int NUMCLIENT { get; set; }

        public int NUMEROCENTRE { get; set; }

        [Column(TypeName = "money")]
        public decimal MONTANTCONTRAT { get; set; }

        public DateTime DATEDEBUT { get; set; }

        public DateTime DATEECHEANCE { get; set; }

        [StringLength(100)]
        public string COMMENTAIRE { get; set; }

        public virtual CENTRE_INFORMATIQUE CENTRE_INFORMATIQUE { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQUIPEMENT> EQUIPEMENT { get; set; }
    }
}
