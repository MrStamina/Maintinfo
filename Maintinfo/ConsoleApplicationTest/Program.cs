using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDal;


namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new MaintinfoContext()))
            {
                var leClient = unitOfWork.Clients.Get(1);
                leClient.NomClient = "Alexandersson";
            }

            //using (var unitOfWork = new UnitOfWork(new MaintinfoContext()))
            //{
            //    var lesCentres = unitOfWork.CentreInformatiques.GetAll();
            //    foreach (var centre in lesCentres)
            //    {
            //        Console.WriteLine(centre.VilleCentre);
            //    }
                
            //}
            //    Console.ReadLine();
        }
    }
}
