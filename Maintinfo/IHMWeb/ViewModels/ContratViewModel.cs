using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BO;

namespace IHMWeb.ViewModels
{
    public class ContratViewModel
    {
        public IEnumerable<Client> Clients { get; set; }

        public IEnumerable<Contrat> Contrats { get; set; }
        public IEnumerable<CentreInformatique> CentraCentreInformatiques { get; set; }
    }
}