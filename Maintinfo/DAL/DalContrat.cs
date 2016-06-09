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
                            string comment = (!dbRdr.IsDBNull(6)) ? dbRdr.GetString(6) : string.Empty;
                            Contrat contrat = new Contrat(numContrat, client, centre, montant,dateDebut,dateEcheance, comment);
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

        public int AddContrat(Contrat contrat)
        {
            using (DbConnection oConnection = Connection.GetConnectionSqlServer())
            {
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "AddContrat";
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Clear();
                    AffectParam(contrat, oCommand);
                    DbParameter odbp7 = oCommand.CreateParameter();
                    odbp7.DbType = DbType.Int32;
                    odbp7.Direction = ParameterDirection.Output;
                    odbp7.ParameterName = "@idContrat";                    
                    oCommand.Parameters.Add(odbp7);
                    
                    try
                    {
                        int n = oCommand.ExecuteNonQuery();
                        if (n != 1)
                            throw new DalExceptionAfficheMessage
                                ("L'opération d'insertion n'a pas été réalisée");
                        return (int)odbp7.Value;

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

        private void AffectParam(Contrat contrat, DbCommand oCommand)
        {
            // 
            DbParameter odbp1 = oCommand.CreateParameter();
            odbp1.DbType = DbType.Int32;
            odbp1.Direction = ParameterDirection.Input;
            odbp1.ParameterName = "@idClient";
            odbp1.Value = contrat.Client.NumClient;
            oCommand.Parameters.Add(odbp1);
            //
            DbParameter odbp2 = oCommand.CreateParameter();
            odbp2.DbType = DbType.Int32;
            odbp2.Direction = ParameterDirection.Input;
            odbp2.ParameterName = "@idCentre";
            odbp2.Value = contrat.CentreInfo.NumCentre;
            oCommand.Parameters.Add(odbp2);
            //
            DbParameter odbp3 = oCommand.CreateParameter();
            odbp3.DbType = DbType.Decimal;
            odbp3.Direction = ParameterDirection.Input;
            odbp3.ParameterName = "@montant";
            odbp3.Value = Convert.ToDecimal(contrat.MontantTtc);
            oCommand.Parameters.Add(odbp3);
            //
            DbParameter odbp4 = oCommand.CreateParameter();
            odbp4.DbType = DbType.DateTime;
            odbp4.Direction = ParameterDirection.Input;
            odbp4.ParameterName = "@datedebut";
            odbp4.Value = contrat.DateDebut;
            oCommand.Parameters.Add(odbp4);
            //
            DbParameter odbp5 = oCommand.CreateParameter();
            odbp5.DbType = DbType.DateTime;
            odbp5.Direction = ParameterDirection.Input;
            odbp5.ParameterName = "@dateecheance";
            odbp5.Value = contrat.DateEcheance;
            oCommand.Parameters.Add(odbp5);
            //
            DbParameter odbp6 = oCommand.CreateParameter();
            odbp6.DbType = DbType.String;
            odbp6.Direction = ParameterDirection.Input;
            odbp6.ParameterName = "@commentaire";
            if (contrat.Commentaire != string.Empty)
                odbp6.Value = contrat.Commentaire;
            else
                odbp6.Value = null;
            oCommand.Parameters.Add(odbp6);


        }
    }
}
