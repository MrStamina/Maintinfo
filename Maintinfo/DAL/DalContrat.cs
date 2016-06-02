using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using DAL.Exceptions;
using BO;
using System.Data;
namespace DAL
{
    public class DalContrat
    {
        public List<Contrat> GetAllContrat()
        {
            List<Contrat> listeContrat = new List<Contrat>();
            using (DbConnection oConnection = Connection.GetConnectionSqlServer())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "GetAllContrat";
                    oCommand.CommandType = CommandType.StoredProcedure;


                    try
                    {
                        DbDataReader dbRdr = oCommand.ExecuteReader();
                        while (dbRdr.Read())
                        {
                            int numContrat = dbRdr.GetInt32(0);
                            Client client = new Client() { NumClient = dbRdr.GetInt32(1) };
                            CentreInformatique centre = new CentreInformatique() { NumCentre = dbRdr.GetInt32(2) };
                            decimal montant = dbRdr.GetDecimal(3);
                            DateTime dateDebut = dbRdr.GetDateTime(4);
                            DateTime dateEcheance = dbRdr.GetDateTime(5);
                            Contrat contrat = new Contrat(numContrat, client, centre, Convert.ToDouble(montant),dateDebut,dateEcheance);
                            listeContrat.Add(contrat);
                        }
                        dbRdr.Close();
                        return listeContrat;
                    }
                    catch (DbException de)
                    {
                        throw new DalExceptionAfficheMessage
                             ("Une erreur s'est produite sur la base : \n" + de.Message, de);
                    }



                }
            }
        }
    }
}
