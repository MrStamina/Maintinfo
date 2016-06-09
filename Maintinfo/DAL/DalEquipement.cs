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
                            int numModele = dbRdr.GetInt32(1);
                            int numTarif = dbRdr.GetInt32(2);
                            decimal montant = dbRdr.GetDecimal(3);
                            string libelle = dbRdr.GetString(4);
                            Tarif tarif = new Tarif() { CodeTarif = numTarif, TarifModele = montant };
                            Modele mod = new Modele() { IdModele = numModele, LibelleModele=libelle.TrimEnd(), Tarif = tarif };
                            Equipement equip = new Equipement(numSerie, mod);
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

        public void UpdEquipement(int numSerie, int numContrat)
        {
            using (DbConnection oConnection = Connection.GetConnectionSqlServer())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "UpdEquipement";
                    oCommand.CommandType = CommandType.StoredProcedure;
                    DbParameter odbp1 = oCommand.CreateParameter();
                    odbp1.DbType = DbType.Int32;
                    odbp1.Direction = ParameterDirection.Input;
                    odbp1.ParameterName = "@numSerie";
                    odbp1.Value = numSerie;
                    oCommand.Parameters.Add(odbp1);
                    DbParameter odbp2 = oCommand.CreateParameter();
                    odbp2.DbType = DbType.Int32;
                    odbp2.Direction = ParameterDirection.Input;
                    odbp2.ParameterName = "@numContrat";
                    odbp2.Value = numContrat;
                    oCommand.Parameters.Add(odbp2);

                    try
                    {
                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DalExceptionAfficheMessage
                                ("L'opération de modification n'a pas été réalisée");
                      

                    }
                    catch (DbException de)
                    {
                        throw new DalExceptionAfficheMessage
                            ("Une erreur s'est produite sur la base : \n"
                                     + de.Message, de);
                    }
                }
            }
        }
    }

        //private void AffectParam(Client client, DbCommand oCommand)
        //{
        //    // 
        //    DbParameter odbp1 = oCommand.CreateParameter();
        //    odbp1.DbType = DbType.String;
        //    odbp1.Direction = ParameterDirection.Input;
        //    odbp1.ParameterName = "@nomClient";
        //    odbp1.Value = client.NomClient;
        //    oCommand.Parameters.Add(odbp1);
        //    //
        //    DbParameter odbp2 = oCommand.CreateParameter();
        //    odbp2.DbType = DbType.String;
        //    odbp2.Direction = ParameterDirection.Input;
        //    odbp2.ParameterName = "@adresseClient";
        //    odbp2.Value = client.AdresseClient;
        //    oCommand.Parameters.Add(odbp2);
        //    //
        //    DbParameter odbp3 = oCommand.CreateParameter();
        //    odbp3.DbType = DbType.String;
        //    odbp3.Direction = ParameterDirection.Input;
        //    odbp3.ParameterName = "@villeClient";
        //    odbp3.Value = client.Ville;
        //    oCommand.Parameters.Add(odbp3);
        //    //
        //    DbParameter odbp4 = oCommand.CreateParameter();
        //    odbp4.DbType = DbType.String;
        //    odbp4.Direction = ParameterDirection.Input;
        //    odbp4.ParameterName = "@codePostal";
        //    odbp4.Value = client.CodePostal;
        //    oCommand.Parameters.Add(odbp4);
        //    //
        //    DbParameter odbp5 = oCommand.CreateParameter();
        //    odbp5.DbType = DbType.String;
        //    odbp5.Direction = ParameterDirection.Input;
        //    odbp5.ParameterName = "@telClient";
        //    odbp5.Value = client.NumTel;
        //    oCommand.Parameters.Add(odbp5);


        
    
}

