namespace TesteHBSIS.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 255, unicode: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Estoque = c.Int(nullable: false),
                        Edicao = c.Int(nullable: false),
                        IdGenero = c.Int(nullable: false),
                        IdAutor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genero", t => t.IdGenero, cascadeDelete: true)
                .ForeignKey("dbo.Autor", t => t.IdAutor, cascadeDelete: true)
                .Index(t => t.IdGenero)
                .Index(t => t.IdAutor);
            
            CreateTable(
                "dbo.Genero",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 255, unicode: false),
                        IdLivro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livro", "IdAutor", "dbo.Autor");
            DropForeignKey("dbo.Livro", "IdGenero", "dbo.Genero");
            DropIndex("dbo.Livro", new[] { "IdAutor" });
            DropIndex("dbo.Livro", new[] { "IdGenero" });
            DropTable("dbo.Genero");
            DropTable("dbo.Livro");
            DropTable("dbo.Autor");
        }
    }
}
