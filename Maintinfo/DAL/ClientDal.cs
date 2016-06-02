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
    public class ClientDal
    {
        public List<Client> GetAllClient()
        {
            List<Client> listClient = new List<Client>();
            using (DbConnection oConnection = Connection.GetConnectionSqlServer())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "GetAllClient";
                    oCommand.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        DbDataReader dbRdr = oCommand.ExecuteReader();
                        while (dbRdr.Read())
                        {
                            int numClient = dbRdr.GetInt32(0);
                            string nomClient = dbRdr.GetString(1);
                            string adresseClient = dbRdr.GetString(2);
                            string villeClient = dbRdr.GetString(3);
                            string codePostal = dbRdr.GetString(4);
                            string telClient = dbRdr.GetString(5);
                            Client client = new Client(numClient, nomClient.TrimEnd(), adresseClient.TrimEnd(), villeClient.TrimEnd(), codePostal, telClient);
                            listClient.Add(client);
                            
                        }
                        dbRdr.Close();
                        return listClient;
                    }
                    catch (DbException de)
                    {
                        throw new DalExceptionAfficheMessage
                             ("Une erreur s'est produite sur la base : \n" + de.Message, de);
                    }

                }
            }
        }

        public int addClient(Client client)
        {
            using (DbConnection oConnection = Connection.GetConnectionSqlServer())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "AddClient";
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Clear();
                    AffectParam(client, oCommand);
                    oCommand.Parameters["@idClient"].Direction = ParameterDirection.Output;


                    try
                    {
                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DalExceptionAfficheMessage
                                ("L'opération d'insertion n'a pas été réalisée");
                        return (int)oCommand.Parameters["@idClient"].Value;

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

        private void AffectParam(Client client, DbCommand oCommand)
        {
            // 
            DbParameter odbp1 = oCommand.CreateParameter();
            odbp1.DbType = DbType.String;
            odbp1.Direction = ParameterDirection.Input;
            odbp1.ParameterName = "@nomClient";
            odbp1.Value = client.NomClient;
            oCommand.Parameters.Add(odbp1);
            //
            DbParameter odbp2 = oCommand.CreateParameter();
            odbp2.DbType = DbType.String;
            odbp2.Direction = ParameterDirection.Input;
            odbp2.ParameterName = "@adresseClient";
            odbp2.Value = client.AdresseClient;
            oCommand.Parameters.Add(odbp2);
            //
            DbParameter odbp3 = oCommand.CreateParameter();
            odbp3.DbType = DbType.String;
            odbp3.Direction = ParameterDirection.Input;
            odbp3.ParameterName = "@villeClient";
            odbp3.Value = client.Ville;
            oCommand.Parameters.Add(odbp3);
            //
            DbParameter odbp4 = oCommand.CreateParameter();
            odbp4.DbType = DbType.String;
            odbp4.Direction = ParameterDirection.Input;
            odbp4.ParameterName = "@codePostal";
            odbp4.Value = client.CodePostal;
            oCommand.Parameters.Add(odbp4);
            //
            DbParameter odbp5 = oCommand.CreateParameter();
            odbp5.DbType = DbType.String;
            odbp5.Direction = ParameterDirection.Input;
            odbp5.ParameterName = "@telClient";
            odbp5.Value = client.NumTel;
            oCommand.Parameters.Add(odbp5);


        }
    }
}

