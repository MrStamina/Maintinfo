using System.Data.Entity.Migrations;

namespace EntityDal.Migrations
{
    public partial class PopulateSecteur : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.Secteurs(Libelle) Values('Sud-Est')");
            Sql("Insert into dbo.Secteurs(Libelle) Values('Ile de France')");
            Sql("Insert into dbo.Secteurs(Libelle) Values('Nord-Est')");
            Sql("Insert into dbo.Secteurs(Libelle) Values('Nord-Ouest')");
            Sql("Insert into dbo.Secteurs(Libelle) Values('Sud-Ouest')");
            Sql("Insert into dbo.Secteurs(Libelle) Values('Centre')");
        }
        
        public override void Down()
        {
        }
    }
}
