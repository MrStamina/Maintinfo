using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class ManagerCentreInformatique
    {
         private List<CentreInformatique> listeCentre;
         private DalCentreInfo dalCentre;
        

        public ManagerCentreInformatique()
        {
            listeCentre = new List<CentreInformatique>();
        }


        public List<CentreInformatique> ChargerCentre()
        {
            
            dalCentre = new DalCentreInfo();
            listeCentre = dalCentre.GetAllCentre();
            return listeCentre;
        }

        public List<CentreInformatique> AfficherCentreParClient(int idclient)
        {
            ChargerCentre();
            List<CentreInformatique> listcentre = listeCentre.FindAll(delegate (CentreInformatique c) { return c.Client.NumClient == idclient; });
            return listcentre;
        }
    }
}
