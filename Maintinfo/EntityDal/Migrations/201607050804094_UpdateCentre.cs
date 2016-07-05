using System.Data.Entity.Migrations;

namespace EntityDal.Migrations
{
    public partial class UpdateCentre : DbMigration
    {
        public override void Up()
        {
            Sql("Update dbo.CentreInformatiques SET ClientId = 1 where Id=4");
            Sql("Update dbo.CentreInformatiques SET ClientId = 1 where Id=5");
            Sql("Update dbo.CentreInformatiques SET ClientId = 1 where Id=6");
            Sql("Update dbo.CentreInformatiques SET ClientId = 1 where Id=7");
        }
        
        public override void Down()
        {
        }
    }
}
