using System.Data.Entity.Migrations;

namespace EntityDal.Migrations
{
    public partial class PopulateContrats : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.Contrats (ClientId,CentreInformatiqueId,Montant,DateDebut,DateEcheance) Values(3,5,4255,'2016-01-01','2017-01-01')");
            Sql("Insert into dbo.Contrats (ClientId,CentreInformatiqueId,Montant,DateDebut,DateEcheance) Values(1,4,2855,'2016-01-01','2017-01-01')");
            Sql("Insert into dbo.Contrats (ClientId,CentreInformatiqueId,Montant,DateDebut,DateEcheance) Values(1,2,4125,'2016-01-01','2017-01-01')");
            Sql("Insert into dbo.Contrats (ClientId,CentreInformatiqueId,Montant,DateDebut,DateEcheance) Values(5,1,1689,'2016-01-01','2017-01-01')");
            Sql("Insert into dbo.Contrats (ClientId,CentreInformatiqueId,Montant,DateDebut,DateEcheance) Values(1,6,2455,'2016-01-01','2017-01-01')");
            Sql("Insert into dbo.Contrats (ClientId,CentreInformatiqueId,Montant,DateDebut,DateEcheance) Values(1,3,3811,'2016-01-01','2017-01-01')");
           
        }
        
        public override void Down()
        {
        }
    }
}
