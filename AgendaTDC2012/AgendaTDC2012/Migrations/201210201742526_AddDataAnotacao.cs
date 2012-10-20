namespace AgendaTDC2012.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnotacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Anotacoes", "Data", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Anotacoes", "Data");
        }
    }
}
