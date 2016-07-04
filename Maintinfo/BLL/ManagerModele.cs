using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDal;


namespace BLL
{
    public class ManagerModele
    {

        private List<Modele> listModele;
       
        public ManagerModele()
        {
            listModele = new List<Modele>();
        }

        //public List<Modele> ChargerModele()
        //{
        //    dalMod = new DalModele();
        //    return listModele = dalMod.GetAllModele();
        //}
    }
}
