using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Contrat
    {
        int NumeroContrat { get; set; }

        CentreInformatique CentreInfo { get; set; }
        Client Client { get; set; }
        decimal MontantHt { get; set; }
        public double Tva = 0.2;
        
    }
}
