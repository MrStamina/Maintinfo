namespace EntityDal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class Equipement
    {
        
        public int Id { get; set; }

        public int ModeleId { get; set; }

        public int CentreInformatiqueId { get; set; }

        public int? ContratId { get; set; }

        public virtual CentreInformatique CentreInformatique { get; set; }

        public virtual Contrat Contrat { get; set; }

        public virtual Modele Modele { get; set; }
    }
}
