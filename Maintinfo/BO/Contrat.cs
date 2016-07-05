using System;
using System.Collections.Generic;

namespace BO
{
    public partial class Contrat
    {
       
        public Contrat()
        {
            
        }

        
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int CentreInformatiqueId { get; set; }

        
        public decimal Montant { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateEcheance { get; set; }

        
        public string Commentaire { get; set; }

        public virtual CentreInformatique CentreInformatique { get; set; }

        public virtual Client Client { get; set; }

        
        public virtual ICollection<Equipement> Equipements { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(Object obj)
        {
            return obj is Contrat && Id == ((Contrat)obj).Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
