using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BO;
//using DAL;
using EntityDal;

namespace BLL
{
    public class ManagerCentreInformatique
    {
         //private List<CentreInformatique> listeCentre;
         //private DalCentreInfo dalCentre;
        private MaintinfoContext context;
        

        public ManagerCentreInformatique()
        {
            context = new MaintinfoContext();
        }


        public IEnumerable<CentreInformatique> ChargerCentre()
        {

            var lesCentres = context.CentreInformatiques.ToList();
            return lesCentres;

        }

        public IEnumerable<CentreInformatique> AfficherCentreParClient(int idclient)
        {
            var lesCentresByClient = context.CentreInformatiques
                .Where(c => c.ClientId == idclient)
                .OrderBy(c => c.VilleCentre);
            return lesCentresByClient;
        }
    }
}
