namespace BookLibrary_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Categorie_CategorieBoek_Classes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategorieBoeken",
                c => new
                    {
                        CategorieBoekID = c.Int(nullable: false, identity: true),
                        BoekId = c.Int(nullable: false),
                        CategorieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategorieBoekID)
                .ForeignKey("dbo.Boeks", t => t.BoekId, cascadeDelete: true)
                .ForeignKey("dbo.Categorieën", t => t.CategorieID, cascadeDelete: true)
                .Index(t => new { t.BoekId, t.CategorieID }, unique: true, name: "BoekIDCategorieID");
            
            CreateTable(
                "dbo.Categorieën",
                c => new
                    {
                        CategorieID = c.Int(nullable: false, identity: true),
                        Naam = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategorieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategorieBoeken", "CategorieID", "dbo.Categorieën");
            DropForeignKey("dbo.CategorieBoeken", "BoekId", "dbo.Boeks");
            DropIndex("dbo.CategorieBoeken", "BoekIDCategorieID");
            DropTable("dbo.Categorieën");
            DropTable("dbo.CategorieBoeken");
        }
    }
}
