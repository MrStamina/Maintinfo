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
    public class DalTarifs
    {
        public List<Tarif> GetAllTarif()
        {
            List<Tarif> listTarif = new List<Tarif>();
            using (DbConnection oConnection = Connection.GetConnectionSqlServer())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "GetAllTarif";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        DbDataReader dbRdr = oCommand.ExecuteReader();
                        while (dbRdr.Read())
                        {
                            int codeTarif = dbRdr.GetInt32(0);
                            DateTime date = dbRdr.GetDateTime(1);
                            decimal tarifMod = dbRdr.GetDecimal(2);
                            Tarif tarif = new Tarif(codeTarif, date, Convert.ToDouble(tarifMod));
                            listTarif.Add(tarif);

                        }
                        dbRdr.Close();
                        return listTarif;
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
