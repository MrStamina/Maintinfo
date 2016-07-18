namespace EntityDal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddNumSerie1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Equipements", "NumeroSerie", c => c.String(nullable: false, maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Equipements", "NumeroSerie", c => c.String());
        }
    }
}
