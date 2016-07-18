using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BO;

namespace IHMWeb.ViewModels
{
    public class CentreInformatiqueFormViewModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Veuillez choisir un secteur géographique")]
        public int SecteurId { get; set; }
        [Required(ErrorMessage = "Veuillez selectionner un client")]
        public int? ClientId { get; set; }

        [Required(ErrorMessage = "Veuilelz saisir l'adresse du centre")]
        [StringLength(100, ErrorMessage = "l'adresse du centre est trop longue")]
        public string AdresseCentre { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer la ville du centre")]
        [StringLength(40, ErrorMessage = "Le nom de la ville est trop long")]
        public string VilleCentre { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer le numéro de téléphone")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Veuillez entrer un numéro de téléphone valide")]
        public string TelCentre { get; set; }

        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Secteur> Secteurs { get; set; }


        public CentreInformatiqueFormViewModel()
        {
            Id = 0;
        }

        public CentreInformatiqueFormViewModel(CentreInformatique centre)
        {
            Id = centre.Id;
            AdresseCentre = centre.AdresseCentre;
            TelCentre = centre.TelCentre;
            VilleCentre = centre.VilleCentre;
            ClientId = centre.ClientId;
            SecteurId = centre.SecteurId;
        }
    }
}