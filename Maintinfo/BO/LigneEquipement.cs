using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LigneEquipement
    {
        public int Qte { get; set; }
        public string Libelle_Modele { get; set; }
        public double Tarif { get; set; }

        public LigneEquipement()
        {

        }

        public LigneEquipement(int qte, string libelle, double tarif)
        {
            this.Qte = qte;
            this.Libelle_Modele = libelle;
            this.Tarif = tarif;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
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
