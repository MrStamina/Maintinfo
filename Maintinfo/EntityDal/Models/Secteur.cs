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

        public override bool Equals(Object obj)
        {
            return obj is Secteur && Id == ((Secteur)obj).Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public Secteur Self
        {
            get { return this; }
        }
    }
}
