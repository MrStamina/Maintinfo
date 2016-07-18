using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BO;

namespace IHMWeb.ViewModels
{
    public class ContratViewModel
    {
        

        public int? Id { get; set; }

        public int ClientId { get; set; }

        public int CentreInformatiqueId { get; set; }

        public decimal MontantHt { get; set; }
        public decimal MontantTtc { get; set; }

        public DateTime DateDebut { get; set; }

        

        [StringLength(100, ErrorMessage = "Le commentaire est trop long")]
        public string Commentaire { get; set; }
       
       

        public Client Client { get; set; }
        public IEnumerable<CentreInformatique> CentreInformatiques { get; set; }

        public IEnumerable<Contrat> Contrats { get; set; }

        public IEnumerable<LigneEquipement> LigneEquipements { get; set; }

        public ContratViewModel()
        {
            Id = 0;
        }

        public ContratViewModel(Contrat contrat)
        {
            ClientId = contrat.ClientId;
            CentreInformatiqueId = contrat.CentreInformatiqueId;
            MontantTtc = contrat.Montant;
            DateDebut = contrat.DateDebut;
           
            Commentaire = contrat.Commentaire;
        }
    }
}