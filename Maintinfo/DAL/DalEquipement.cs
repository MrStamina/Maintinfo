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
    public class DalEquipement
    {
        public List<Equipement> GetEquipementByCentre(int idCentre)
        {
            List<Equipement> listEquip = new List<Equipement>();
            using (DbConnection oConnection = Connection.GetConnectionSqlServer())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "GetEquipementByCentre";
                    oCommand.CommandType = CommandType.StoredProcedure;
                    DbParameter odbp1 = oCommand.CreateParameter();
                    odbp1.DbType = DbType.String;
                    odbp1.Direction = ParameterDirection.Input;
                    odbp1.ParameterName = "@idCentre";
                    odbp1.Value = idCentre;
                    oCommand.Parameters.Add(odbp1);

                    try
                    {
                        DbDataReader dbRdr = oCommand.ExecuteReader();
                        while (dbRdr.Read())
                        {
                            int numSerie = dbRdr.GetInt32(0);
                            Modele mod = new Modele() { IdModele = dbRdr.GetInt32(1) };
                            CentreInformatique centre = new CentreInformatique() { NumCentre = dbRdr.GetInt32(2) };
                            Equipement equip = new Equipement(numSerie, mod, centre);
                            listEquip.Add(equip);

                        }
                        dbRdr.Close();
                        return listEquip;
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

