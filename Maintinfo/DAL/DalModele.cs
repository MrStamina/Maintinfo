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
    public class DalModele
    {
        public List<Modele> GetAllModele()
        {
            List<Modele> listModele = new List<Modele>();
            using (DbConnection oConnection = Connection.GetConnectionSqlServer())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "GetAllModele";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        DbDataReader dbRdr = oCommand.ExecuteReader();
                        while (dbRdr.Read())
                        {
                            int idModele = dbRdr.GetInt32(0);
                            BO.Type type = new BO.Type() { IdType = dbRdr.GetInt32(1) };
                            Tarif tarif = new Tarif() { CodeTarif = dbRdr.GetInt32(2) };
                            string libelle = dbRdr.GetString(3);
                            Modele mod = new Modele(idModele, libelle.TrimEnd(), type, tarif);
                            listModele.Add(mod);

                        }
                        dbRdr.Close();
                        return listModele;
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
