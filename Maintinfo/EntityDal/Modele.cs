namespace EntityDal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class Modele
    {
        
        public Modele()
        {
            ;
        }

        public int Id { get; set; }

        public int TypeId { get; set; }

        public byte TarifId { get; set; }

        
        public string Libelle { get; set; }

       
        public virtual ICollection<Equipement> Equipements { get; set; }

        public virtual TypeEquipement TypeEquipement { get; set; }

        public virtual Tarif Tarif { get; set; }
    }
}
