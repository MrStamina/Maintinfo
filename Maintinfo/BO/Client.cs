using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Client
    {
        public int NumClient { get; set; }
        public string NomClient { get; set; }

        public string AdresseClient { get; set; }

        public string NumTel { get; set; }

        public string Ville { get; set; }

        public string CodePostal { get; set; }

        List<CentreInformatique> CentreInformatique { get; set; }

        public Client()
        {

        }

        public Client(int num, string nom, string adresse, string ville, string codePo, string numTel)
        {
            this.NumClient = num;
            this.NomClient = nom;
            this.AdresseClient = adresse;
            this.Ville = ville;
            this.CodePostal = codePo;
            this.NumTel = numTel;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(Object obj)
        {
            return obj is Client && NumClient == ((Client)obj).NumClient;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
