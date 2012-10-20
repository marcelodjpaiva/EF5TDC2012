namespace AgendaTDC2012.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50),
                        Endereco = c.String(maxLength: 100),
                        Telefone = c.String(maxLength: 20),
                        Tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Anotacoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nota = c.String(maxLength: 250),
                        Contato_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contatos", t => t.Contato_Id)
                .Index(t => t.Contato_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Anotacoes", new[] { "Contato_Id" });
            DropForeignKey("dbo.Anotacoes", "Contato_Id", "dbo.Contatos");
            DropTable("dbo.Anotacoes");
            DropTable("dbo.Contatos");
        }
    }
}
