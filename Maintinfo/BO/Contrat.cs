using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Contrat
    {
        public int NumeroContrat { get; set; }

        public CentreInformatique CentreInfo { get; set; }
        public Client Client { get; set; }
        public decimal MontantHt { get; set; }

        //si le contrat ne concerne pas tous les équipements

        public List<Equipement> Equipement { get; set; }

        public Contrat()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(Object obj)
        {
            return obj is Contrat && NumeroContrat == ((Contrat)obj).NumeroContrat;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
