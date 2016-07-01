namespace EntityDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CentreInformatiques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SecteurId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        AdresseCentre = c.String(nullable: false, maxLength: 100, unicode: false),
                        VilleCentre = c.String(nullable: false, maxLength: 40, unicode: false),
                        TelCentre = c.String(nullable: false, maxLength: 12, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.Secteurs", t => t.SecteurId)
                .Index(t => t.SecteurId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClient = c.String(nullable: false, maxLength: 40, unicode: false),
                        Adresse = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ville = c.String(nullable: false, maxLength: 50, unicode: false),
                        CodePostal = c.String(nullable: false, maxLength: 5, unicode: false),
                        Telephone = c.String(nullable: false, maxLength: 12, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contrats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        CentreInformatiqueId = c.Int(nullable: false),
                        Montant = c.Decimal(nullable: false, storeType: "money"),
                        DateDebut = c.DateTime(nullable: false),
                        DateEcheance = c.DateTime(nullable: false),
                        Commentaire = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.CentreInformatiques", t => t.CentreInformatiqueId)
                .Index(t => t.ClientId)
                .Index(t => t.CentreInformatiqueId);
            
            CreateTable(
                "dbo.Equipements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModeleId = c.Int(nullable: false),
                        CentreInformatiqueId = c.Int(nullable: false),
                        ContratId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contrats", t => t.ContratId)
                .ForeignKey("dbo.Modeles", t => t.ModeleId)
                .ForeignKey("dbo.CentreInformatiques", t => t.CentreInformatiqueId)
                .Index(t => t.ModeleId)
                .Index(t => t.CentreInformatiqueId)
                .Index(t => t.ContratId);
            
            CreateTable(
                "dbo.Modeles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeId = c.Int(nullable: false),
                        TarifId = c.Byte(nullable: false),
                        Libelle = c.String(nullable: false, maxLength: 40, unicode: false),
                        TypeEquipement_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypeEquipements", t => t.TypeEquipement_Id)
                .Index(t => t.TypeEquipement_Id);
            
            CreateTable(
                "dbo.Tarifs",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        DateTarif = c.DateTime(nullable: false),
                        TarifModele = c.Decimal(nullable: false, storeType: "money"),
                        Modele_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modeles", t => t.Modele_Id)
                .Index(t => t.Modele_Id);
            
            CreateTable(
                "dbo.TypeEquipements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(nullable: false, maxLength: 40, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Secteurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(nullable: false, maxLength: 40, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CentreInformatiques", "SecteurId", "dbo.Secteurs");
            DropForeignKey("dbo.Equipements", "CentreInformatiqueId", "dbo.CentreInformatiques");
            DropForeignKey("dbo.Contrats", "CentreInformatiqueId", "dbo.CentreInformatiques");
            DropForeignKey("dbo.Contrats", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Modeles", "TypeEquipement_Id", "dbo.TypeEquipements");
            DropForeignKey("dbo.Tarifs", "Modele_Id", "dbo.Modeles");
            DropForeignKey("dbo.Equipements", "ModeleId", "dbo.Modeles");
            DropForeignKey("dbo.Equipements", "ContratId", "dbo.Contrats");
            DropForeignKey("dbo.CentreInformatiques", "ClientId", "dbo.Clients");
            DropIndex("dbo.Tarifs", new[] { "Modele_Id" });
            DropIndex("dbo.Modeles", new[] { "TypeEquipement_Id" });
            DropIndex("dbo.Equipements", new[] { "ContratId" });
            DropIndex("dbo.Equipements", new[] { "CentreInformatiqueId" });
            DropIndex("dbo.Equipements", new[] { "ModeleId" });
            DropIndex("dbo.Contrats", new[] { "CentreInformatiqueId" });
            DropIndex("dbo.Contrats", new[] { "ClientId" });
            DropIndex("dbo.CentreInformatiques", new[] { "ClientId" });
            DropIndex("dbo.CentreInformatiques", new[] { "SecteurId" });
            DropTable("dbo.Secteurs");
            DropTable("dbo.TypeEquipements");
            DropTable("dbo.Tarifs");
            DropTable("dbo.Modeles");
            DropTable("dbo.Equipements");
            DropTable("dbo.Contrats");
            DropTable("dbo.Clients");
            DropTable("dbo.CentreInformatiques");
        }
    }
}
