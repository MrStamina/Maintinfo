using System;

namespace BO
{
    public partial class Equipement
    {
        
        public int Id { get; set; }

        public string NumeroSerie { get; set; }

        public int ModeleId { get; set; }

        public int CentreInformatiqueId { get; set; }

        public int? ContratId { get; set; }

        public virtual CentreInformatique CentreInformatique { get; set; }

        public virtual Contrat Contrat { get; set; }

        public virtual Modele Modele { get; set; }

        public override bool Equals(Object obj)
        {
            return obj is Equipement && Id == ((Equipement)obj).Id;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
