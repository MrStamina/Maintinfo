using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Equipement 
    {
        public int NumeroSerie { get; set; }
        public Modele Modele { get; set; }
        public CentreInformatique Centre { get; set; }
        public Contrat Contrat { get; set; }

        //public Tarif Tarif { get; set; }

        public Equipement()
        {

        }

        public Equipement(int numserie, Modele mod)
        {
            this.NumeroSerie = numserie;
            this.Modele = mod;
          
            
        }
        public Equipement(int numserie, Modele mod, CentreInformatique centre)
        {
            this.NumeroSerie = numserie;
            this.Modele = mod;
            this.Centre = centre;
        }

        public override bool Equals(Object obj)
        {
            return obj is Equipement && NumeroSerie == ((Equipement)obj).NumeroSerie;
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
