using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class SecteurGeographique
    {
        public int IdSecteur { get; set; }
        public string LibelleSecteur { get; set; }

        public SecteurGeographique()
        {

        }

        public SecteurGeographique(int id, string libelle)
        {
            this.IdSecteur = id;
            this.LibelleSecteur = libelle;
        }

        public override bool Equals(Object obj)
        {
            return obj is SecteurGeographique && IdSecteur == ((SecteurGeographique)obj).IdSecteur;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public SecteurGeographique Self
        {
            get { return this; }
        }
    }
}
