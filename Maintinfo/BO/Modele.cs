using System;
using System.Collections.Generic;

namespace BO
{
    public partial class Modele
    {
        
        public Modele()
        {
            
        }

        public int Id { get; set; }

        public int TypeId { get; set; }

        public byte TarifId { get; set; }

        
        public string Libelle { get; set; }

        

       
        public virtual ICollection<Equipement> Equipements { get; set; }

        public virtual TypeEquipement TypeEquipement { get; set; }

        public virtual Tarif Tarif { get; set; }

        public override bool Equals(Object obj)
        {
            return obj is Modele && Id == ((Modele)obj).Id;
        }
        public override string ToString()
        {
            return Libelle;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
