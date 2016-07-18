namespace EntityDal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddNumSerie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipements", "NumeroSerie", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipements", "NumeroSerie");
        }
    }
}
