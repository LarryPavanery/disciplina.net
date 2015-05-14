namespace Sebo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        EditoraID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.EditoraID);
            
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        LivroID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Editora_EditoraID = c.Int(),
                    })
                .PrimaryKey(t => t.LivroID)
                .ForeignKey("dbo.Editoras", t => t.Editora_EditoraID)
                .Index(t => t.Editora_EditoraID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livroes", "Editora_EditoraID", "dbo.Editoras");
            DropIndex("dbo.Livroes", new[] { "Editora_EditoraID" });
            DropTable("dbo.Livroes");
            DropTable("dbo.Editoras");
        }
    }
}
