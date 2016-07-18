namespace EntityDal.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PopulateModele : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.TypeEquipements (Libelle) values('Ordinateur de bureau')");
            Sql("Insert into dbo.TypeEquipements (Libelle) values('Ordinateur portable')");
            Sql("Insert into dbo.TypeEquipements (Libelle) values('Serveur')");
            Sql("Insert into dbo.TypeEquipements (Libelle) values('Unit� de stockage')");
            Sql("Insert into dbo.TypeEquipements (Libelle) values('Commutateurs r�seaux')");

        }
        
        public override void Down()
        {
        }
    }
}
