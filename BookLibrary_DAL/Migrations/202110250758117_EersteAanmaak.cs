namespace BookLibrary_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EersteAanmaak : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boeks",
                c => new
                    {
                        BoekId = c.Int(nullable: false, identity: true),
                        CategorieId = c.Int(nullable: false),
                        Naam = c.String(),
                        Auteur = c.String(),
                        Uitgever = c.String(),
                        ISBN = c.String(),
                        Leeftijdsklasse = c.String(),
                        IsVerkocht = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BoekId);
            
            CreateTable(
                "dbo.Boekenbeurs",
                c => new
                    {
                        BoekenbeursID = c.Int(nullable: false, identity: true),
                        Locatie = c.String(),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.BoekenbeursID);
            
            CreateTable(
                "dbo.Inschrijvings",
                c => new
                    {
                        InschrijvingID = c.Int(nullable: false, identity: true),
                        BoekenbeursID = c.Int(nullable: false),
                        GebruikerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InschrijvingID)
                .ForeignKey("dbo.Boekenbeurs", t => t.BoekenbeursID, cascadeDelete: true)
                .ForeignKey("dbo.Gebruikers", t => t.GebruikerID, cascadeDelete: true)
                .Index(t => t.BoekenbeursID)
                .Index(t => t.GebruikerID);
            
            CreateTable(
                "dbo.Gebruikers",
                c => new
                    {
                        GebruikerID = c.Int(nullable: false, identity: true),
                        Voornaam = c.String(),
                        Achternaam = c.String(),
                        Straat = c.String(),
                        Gemeente = c.String(),
                        Postcode = c.String(),
                        Email = c.String(),
                        IsLid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GebruikerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inschrijvings", "GebruikerID", "dbo.Gebruikers");
            DropForeignKey("dbo.Inschrijvings", "BoekenbeursID", "dbo.Boekenbeurs");
            DropIndex("dbo.Inschrijvings", new[] { "GebruikerID" });
            DropIndex("dbo.Inschrijvings", new[] { "BoekenbeursID" });
            DropTable("dbo.Gebruikers");
            DropTable("dbo.Inschrijvings");
            DropTable("dbo.Boekenbeurs");
            DropTable("dbo.Boeks");
        }
    }
}
