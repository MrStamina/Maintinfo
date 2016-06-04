using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class ManagerModele
    {

        List<Modele> listModele;
        DalModele dalMod;
        public ManagerModele()
        {
            listModele = new List<Modele>();
        }

        public List<Modele> ChargerModele()
        {
            dalMod = new DalModele();
            return listModele = dalMod.GetAllModele();
        }
    }
}
