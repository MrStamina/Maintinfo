namespace EntityDal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class Tarif
    {
        
        public Tarif()
        {
            
        }

       
        public byte Id { get; set; }

        public DateTime DateTarif { get; set; }

       
        public decimal TarifModele { get; set; }

        
        public virtual Modele Modele { get; set; }
    }
}
