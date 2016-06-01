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

        //si le contrat ne concerne pas tous les équipements

        List<Equipement> Equipement { get; set; }
      
        
    }
}
