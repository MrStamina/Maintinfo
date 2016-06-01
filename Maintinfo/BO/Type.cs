using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Type
    {
        public int IdType { get; set; }
        public string LibelleType { get; set; }

        public Type()
        {

        }
        public Type(int id, string libelle)
        {
            this.IdType = id;
            this.LibelleType = libelle;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            return obj is Type && IdType == ((Type)obj).IdType;
        }
    }
}
