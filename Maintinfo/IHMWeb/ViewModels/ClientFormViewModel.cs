using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BO;

namespace IHMWeb.ViewModels
{
    public class ClientFormViewModel
    {
        public int? Id { get; set; }
        public string NomClient { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string CodePostal { get; set; }
        public int ContratId { get; set; }
        public int CentreInformatiqueId { get; set; }
        public IEnumerable<CentreInformatique> CentreInformatiques { get; set; }
        public IEnumerable<Contrat> Contrats { get; set; }
       

        public string Titre
        {
            get
            {
                return Id !=0 ? "Modifier Client" :
                "Nouveau Client";
            }
        }

        public ClientFormViewModel()
        {
            Id = 0;
        }

        public ClientFormViewModel(Client client)
        {
            Id = client.Id;
            NomClient = client.NomClient;
            Adresse = client.Adresse;
            Telephone = client.Telephone;
            Ville = client.Ville;
            CodePostal = client.CodePostal;
        }
    }
}