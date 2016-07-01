namespace EntityDal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class Secteur
    {
        
        public Secteur()
        {
            
        }

        
        public int Id { get; set; }

        
        public string Libelle{ get; set; }

        
        public virtual ICollection<CentreInformatique> CentreInformatiques { get; set; }
    }
}
