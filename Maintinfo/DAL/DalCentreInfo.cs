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
    public class DalCentreInfo
    {
        public List<CentreInformatique> GetAllCentre()
        {
            List<CentreInformatique> listCentre = new List<CentreInformatique>();
            using (DbConnection oConnection = Connection.GetConnectionSqlServer())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "GetAllCentre";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        DbDataReader dbRdr = oCommand.ExecuteReader();
                        while (dbRdr.Read())
                        {
                            int numCentre = dbRdr.GetInt32(0);
                            SecteurGeographique sect = new SecteurGeographique() { IdSecteur = dbRdr.GetInt32(1) };
                            Client client = new Client() { NumClient = dbRdr.GetInt32(2) };
                            string adresse = dbRdr.GetString(3);
                            string ville = dbRdr.GetString(4);
                            string tel = dbRdr.GetString(5);
                            CentreInformatique centreInf = new CentreInformatique(numCentre, sect, client, adresse.TrimEnd(), ville.TrimEnd(), tel);
                            listCentre.Add(centreInf);

                        }
                        dbRdr.Close();
                        return listCentre;
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
