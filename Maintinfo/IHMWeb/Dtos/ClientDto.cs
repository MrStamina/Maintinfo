using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHMWeb.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }


        public string NomClient { get; set; }


        public string Adresse { get; set; }


        public string Ville { get; set; }


        public string CodePostal { get; set; }


        public string Telephone { get; set; }


        //public virtual ICollection<CentreInformatique> CentreInformatiques { get; set; }


        //public virtual ICollection<Contrat> Contrats { get; set; }
    }
}