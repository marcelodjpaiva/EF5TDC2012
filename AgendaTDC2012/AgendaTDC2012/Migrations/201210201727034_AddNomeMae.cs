namespace AgendaTDC2012.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNomeMae : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contatos", "NomeMae", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contatos", "NomeMae");
        }
    }
}
