using System;

namespace BO
{
    public partial class Tarif
    {
        
        public Tarif()
        {
            
        }

       
        public byte Id { get; set; }

        public DateTime DateTarif { get; set; }

       
        public decimal TarifModele { get; set; }

        
        public virtual Modele Modele { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(Object obj)
        {
            return obj is Tarif && Id == ((Tarif)obj).Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Tarif Self
        {
            get { return this; }
        }
    }
}
