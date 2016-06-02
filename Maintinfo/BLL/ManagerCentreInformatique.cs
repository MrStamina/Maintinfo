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
        List<CentreInformatique> listeCentre;
        DalCentreInfo dalCentre;


        public List<CentreInformatique> chargerCentre()
        {
            listeCentre = new List<CentreInformatique>();
            dalCentre = new DalCentreInfo();
            listeCentre = dalCentre.GetAllCentre();
            return listeCentre;
        }
    }
}
