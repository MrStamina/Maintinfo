using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class AvisRenouvellement
    {
        public Client Client { get; set; }
        public CentreInformatique Centre { get; set; }
        public Contrat Contrat { get; set; }
        
        public string Changement { get; set; }

        public double ? NouveauMontant { get; set; }

        public AvisRenouvellement()
        {

        }
    }
}
