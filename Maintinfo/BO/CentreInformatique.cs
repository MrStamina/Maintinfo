using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class CentreInformatique
    {
        public int NumCentre { get; set; }
        public string AdresseCentre { get; set; }
        public string NumTelCentre { get; set; }
        public string Ville { get; set; }

        List<Equipement> Equipement { get; set; }

        SecteurGeographique Secteur { get; set; }

        public CentreInformatique()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(Object obj)
        {
            return obj is CentreInformatique && NumCentre == ((CentreInformatique)obj).NumCentre;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
