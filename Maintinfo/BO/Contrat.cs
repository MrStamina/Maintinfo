using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Contrat
    {
        public int NumeroContrat { get; set; }

        public CentreInformatique CentreInfo { get; set; }
        public Client Client { get; set; }
        public double MontantTtc { get; set; }

        public DateTime DateDebut { get; set; }
        public DateTime DateEcheance { get; set; }

        public string Commentaire { get; set; }

        public StatutContrat statut { get; set; }
        //si le contrat ne concerne pas tous les équipements

        public List<Equipement> Equipement { get; set; }

        public Contrat()
        {

        }
        public Contrat(int id,Client client, CentreInformatique centre, double montant, DateTime dateDebut, DateTime dateEcheance,string comment)
        {
            this.NumeroContrat = id;
            this.Client = client;
            this.CentreInfo = centre;
            this.MontantTtc = montant;
            this.DateDebut = dateDebut;
            this.DateEcheance = dateEcheance;
            this.Commentaire = comment;
       
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(Object obj)
        {
            return obj is Contrat && NumeroContrat == ((Contrat)obj).NumeroContrat;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
