namespace EntityDal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TypeEquipement
    {
        
        public TypeEquipement()
        {
           
        }

       
        public int Id { get; set; }

        
        public string Libelle{ get; set; }

        
        public virtual ICollection<Modele> Modeles { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            return obj is TypeEquipement && Id == ((TypeEquipement)obj).Id;
        }
    }
}
