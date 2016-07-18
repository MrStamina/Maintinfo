namespace EntityDal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PopulateModele1 : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.Modeles (Libelle,TypeEquipement_Id) values('Optiplex 7010', 11)");
            Sql("Insert into dbo.Modeles (Libelle,TypeEquipement_Id) values('Optiplex 7020', 11)");
            Sql("Insert into dbo.Modeles (Libelle,TypeEquipement_Id) values('Latitude Serie 5000', 12)");
            Sql("Insert into dbo.Modeles (Libelle,TypeEquipement_Id) values('PowerEdge R930', 14)");
            Sql("Insert into dbo.Modeles (Libelle,TypeEquipement_Id) values('Latitude Serie 6000', 12)");
            Sql("Insert into dbo.Modeles (Libelle,TypeEquipement_Id) values('Hub 5350', 15)");
        }
        
        public override void Down()
        {
        }
    }
}
