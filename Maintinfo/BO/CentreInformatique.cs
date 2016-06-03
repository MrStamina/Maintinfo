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

        public List<Equipement> Equipement { get; set; }

        public SecteurGeographique Secteur { get; set; }

        public  Client Client { get; set; }

        public CentreInformatique()
        {

        }

        public CentreInformatique(int num, string adresse,string ville, string numTel, List<Equipement> equip, SecteurGeographique sect)
        {
            this.NumCentre = num;
            this.AdresseCentre = adresse;
            this.Ville = ville;
            this.NumTelCentre = numTel;
            this.Equipement = equip;
            this.Secteur = sect;
        }

        public CentreInformatique(int num, SecteurGeographique sect, Client client, string adresse,string ville,string tel )
        {
            this.NumCentre = num;
            this.Secteur = sect;
            this.Client = client;
            this.AdresseCentre = adresse;
            this.Ville = ville;
            this.NumTelCentre = tel;
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

        public CentreInformatique Self
        {
            get { return this; }
        }
    }
}
