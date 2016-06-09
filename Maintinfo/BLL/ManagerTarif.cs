using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class ManagerTarif
    {
        private DalTarifs dalTarif;
        private List<Tarif> listTarifs;

        public ManagerTarif()
        {
            listTarifs = new List<Tarif>();
        }

        public List<Tarif> ChargerTarif()
        {
            dalTarif = new DalTarifs();
            listTarifs = dalTarif.GetAllTarif();
            return listTarifs;
        }
    }
}
