namespace EntityDal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CentreInformatique
    {
       
        public CentreInformatique()
        {
           
        }

        
        public int Id { get; set; }

        public int SecteurId { get; set; }

        public int ClientId { get; set; }

        
        public string AdresseCentre { get; set; }

        public string VilleCentre { get; set; }

        
        public string TelCentre { get; set; }

        public virtual Client Client { get; set; }

        public virtual Secteur Secteur { get; set; }

        
        public virtual ICollection<Contrat> Contrat { get; set; }

        
        public virtual ICollection<Equipement> Equipements { get; set; }

        public CentreInformatique Self
        {
            get { return this; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(Object obj)
        {
            return obj is CentreInformatique && Id == ((CentreInformatique)obj).Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
