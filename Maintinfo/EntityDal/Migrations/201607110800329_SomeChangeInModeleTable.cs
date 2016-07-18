namespace EntityDal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SomeChangeInModeleTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Equipements", "NumeroSerie", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Equipements", "NumeroSerie", c => c.String(nullable: false, maxLength: 12));
        }
    }
}
