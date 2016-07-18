namespace EntityDal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AnOtherUpdateOnModele : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Modeles", "TypeId");
            DropColumn("dbo.Tarifs", "ModeleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tarifs", "ModeleId", c => c.Int(nullable: false));
            AddColumn("dbo.Modeles", "TypeId", c => c.Int(nullable: false));
        }
    }
}
