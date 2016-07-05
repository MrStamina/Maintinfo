using System.Data.Entity.Migrations;

namespace EntityDal.Migrations
{
    public partial class PopulateCentre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.CentreInformatiques (SecteurId,ClientId,AdresseCentre,VilleCentre,TelCentre) Values(5,3,'55 imm Raimbault','Bordeaux','0595256541')");
            Sql("Insert into dbo.CentreInformatiques (SecteurId,ClientId,AdresseCentre,VilleCentre,TelCentre) Values(2,4,'25 bd des chèvres','Paris','0152638947')");
            Sql("Insert into dbo.CentreInformatiques (SecteurId,ClientId,AdresseCentre,VilleCentre,TelCentre) Values(1,5,'23 baie des cochons','Hyeres','0494526358')");
            Sql("Insert into dbo.CentreInformatiques (SecteurId,ClientId,AdresseCentre,VilleCentre,TelCentre) Values(2,3,'19 rue de la truite','Versailles','0122554689')");
            Sql("Insert into dbo.CentreInformatiques (SecteurId,ClientId,AdresseCentre,VilleCentre,TelCentre) Values(4,3,'125 av de la Gourde','Brest','0256897420')");
            Sql("Insert into dbo.CentreInformatiques (SecteurId,ClientId,AdresseCentre,VilleCentre,TelCentre) Values(6,3,'10 rue de la yourte','Clermont','0319452587')");
            Sql("Insert into dbo.CentreInformatiques (SecteurId,ClientId,AdresseCentre,VilleCentre,TelCentre) Values(3,3,'Za Les Lapins nains','Strasbourg','0254896932')");
        }
        
        public override void Down()
        {
        }
    }
}
