namespace EntityDal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTarif : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tarifs", "ModeleId", c => c.Int(nullable: false));
            DropColumn("dbo.Modeles", "TarifId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Modeles", "TarifId", c => c.Byte(nullable: false));
            DropColumn("dbo.Tarifs", "ModeleId");
        }
    }
}
