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

            using (var db = new MaintinfoContext())
            {
                var lesClients = db.Clients.ToList();
                foreach (var client in  lesClients)
                {
                    Console.WriteLine(client.NomClient);
                }
            }
        }
    }
}
