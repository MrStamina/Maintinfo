using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using EntityDal;

namespace BusinessLogicLayer
{
   public class ManagerModele
   {
       private UnitOfWork unitOfWork;
       private MaintinfoContext _context;

       public ManagerModele()
       {
           _context = new MaintinfoContext();
            unitOfWork = new UnitOfWork(_context);
       }


       public IEnumerable<Modele> GetAllModeles()
       {
           return unitOfWork.Modeles.GetAll();
       }

        //Appel des secteurs

       public IEnumerable<Secteur> GetAllSecteurs()
       {
           return unitOfWork.Secteurs.GetAll();
       }
   }
}
