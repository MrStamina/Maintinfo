namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EQUIPEMENT")]
    public partial class EQUIPEMENT
    {
        [Key]
        public int NUMEROSERIE { get; set; }

        public int IDMODELE { get; set; }

        public int NUMEROCENTRE { get; set; }

        public int? NUMCONTRAT { get; set; }

        public virtual CENTRE_INFORMATIQUE CENTRE_INFORMATIQUE { get; set; }

        public virtual CONTRAT CONTRAT { get; set; }

        public virtual MODELE MODELE { get; set; }
    }
}
