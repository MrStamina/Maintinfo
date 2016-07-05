//using BO;
//using DAL;

namespace BLL
{
    public class ManagerContrat
    {

        private decimal tva = 0.2M;
        private decimal montantTtc;
        
        //private DalContrat dalContrat;
        //private MaintinfoContext context;


        //public ManagerContrat()
        //{
        //    context = new MaintinfoContext();

        //}

        //public List<Contrat> ChargerLesContrats()
        //{
        //    var listContrat = context.Contrats.ToList();
        //    return listContrat;
        //}
        //public List<Contrat> ConsulterContratParClient(int idclient)
        //{

        //    var contratByClient = context.Contrats
        //        .Where(c => c.ClientId.Equals(idclient))
        //        .OrderBy(c => c.CentreInformatique.VilleCentre)
        //        .ToList();
        //    return contratByClient;

        //}

        //    public int EnregistrerContrat(Contrat contrat)
        //    {
        //        dalContrat = new DalContrat();
        //        return dalContrat.AddContrat(contrat);

        //    }

        //    public bool ModifierContrat(Contrat contrat)
        //    {
        //        return true;
        //    }

        //    public bool SupprimerContrat(Contrat contrat)
        //    {
        //        return true;
        //    }

        //// méthodes pour calculer automatiquement les montants du contrat en fonction des equipements
        //    public decimal CalculerMontantHt(List<LigneEquipement> listequip)
        //    {
        //        decimal montantHt = 0;
        //        foreach (LigneEquipement equip in listequip)
        //        {

        //            montantHt += equip.Tarif;
        //        }
        //        return montantHt;



        //    }
        //    public decimal CalculerMontantTtc(decimal montantHt)
        //    {

        //        montantTtc = (montantHt + (montantHt * tva));            
        //        return montantTtc;
        //    }

        //    public decimal AppliquerRemise(decimal remise)
        //    {
        //        if (remise != 0)
        //        {
        //            return montantTtc - (montantTtc * remise);
        //        }
        //        else
        //            return montantTtc;
        //    }

        //    public DateTime CalculerDateEcheance(DateTime datedebut)
        //    {
        //        return datedebut.AddYears(1);
        //    }
    }
}
