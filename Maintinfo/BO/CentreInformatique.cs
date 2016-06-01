using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class CentreInformatique
    {
        int NumCentre { get; set; }
        string AdresseCentre { get; set; }
        string NumTelCentre { get; set; }
        string Ville { get; set; }

        List<Equipement> Equipement { get; set; }

        SecteurGeographique Secteur { get; set; }
    }
}
