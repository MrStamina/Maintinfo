using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Tarif
    {
        public int CodeTarif { get; set; }
        public DateTime DateTarif { get; set; }
        public decimal TarifModele { get; set; }

        public Tarif()
        {

        }

        public Tarif(int code, DateTime date, decimal tarifMod)
        {
            this.CodeTarif = code;
            this.DateTarif = date;
            this.TarifModele = tarifMod;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(Object obj)
        {
            return obj is Tarif && CodeTarif == ((Tarif)obj).CodeTarif;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Tarif Self
        {
            get { return this; }
        }
    }
}
