namespace EntityDal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public partial class Client
    {
        
        public Client()
        {
            
        }

        
        public int Id { get; set; }

        
        public string NomClient { get; set; }

        
        public string Adresse { get; set; }

        
        public string Ville { get; set; }

        
        public string CodePostal { get; set; }

        
        public string Telephone { get; set; }

       
        public virtual ICollection<CentreInformatique> CentreInformatiques { get; set; }

        
        public virtual ICollection<Contrat> Contrats { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(Object obj)
        {
            return obj is Client && Id == ((Client)obj).Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Client Self
        {
            get { return this; }
        }
    }
}
