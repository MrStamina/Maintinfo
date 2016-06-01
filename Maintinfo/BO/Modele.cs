﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Modele
    {
        public int IdModele { get; set; }
        public string LibelleModele { get; set; }

        public Type Type { get; set; }

        public Modele()
        {

        }

        public Modele(int id, string nomMod, Type type)
        {
            this.IdModele = id;
            this.LibelleModele = nomMod;
            this.Type = type;
        }

        public override bool Equals(Object obj)
        {
            return obj is Modele && IdModele == ((Modele)obj).IdModele;
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
