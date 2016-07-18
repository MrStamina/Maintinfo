using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using BO;

namespace IHMWeb.ViewModels
{
    public class ClientFormViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(40, ErrorMessage = "Le nom est trop long")]
        public string NomClient { get; set; }

        [Required(ErrorMessage = "L'adresse du client est requise")]
        [StringLength(100,ErrorMessage = "L'adresse est trop longue")]
        public string Adresse { get; set; }
        [Required(ErrorMessage = "Veuillez saisir une ville")]
        [StringLength(50,ErrorMessage = "Le nom de la ville est trop long")]
        public string Ville { get; set; }
        [Required(ErrorMessage = "Veuillez saisir un numéro de telephone")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Veuillez entrer un numéro de téléphone valide")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Veuillez saisir un code postal")]
        [DataType(DataType.PostalCode, ErrorMessage = "Le code postal n'est pas au bon format")]
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