namespace EntityDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClient : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.Clients (Nomclient,Adresse,Ville,CodePostal,Telephone) Values('Girard','10 rue de la masse','Aix en Provence','13100','0671427188')");
            Sql("Insert into dbo.Clients (Nomclient,Adresse,Ville,CodePostal,Telephone) Values('Lisi','14 av Mescouillesauski','Marignane','13700','0671427188')");
            Sql("Insert into dbo.Clients (Nomclient,Adresse,Ville,CodePostal,Telephone) Values('Gauthier','25 bd des lilas','Les Mées','04190','0671427188')");
            Sql("Insert into dbo.Clients (Nomclient,Adresse,Ville,CodePostal,Telephone) Values('Chiramonte','20 rue des pommiers','Marseille','13009','0671427188')");
            Sql("Insert into dbo.Clients (Nomclient,Adresse,Ville,CodePostal,Telephone) Values('Ben-Brahim','43 av du chacal des Carpates','Stiring Wendel','57350','0671427188')");
            Sql("Insert into dbo.Clients (Nomclient,Adresse,Ville,CodePostal,Telephone) Values('Guttmann','Impasse le Ronflex','Bordeaux','33000','0671427188')");
        }
        
        public override void Down()
        {
        }
    }
}
