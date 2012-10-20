namespace AgendaTDC2012.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnotacao2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Anotacoes", "Data", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Anotacoes", "Data", c => c.DateTime(nullable: false));
        }
    }
}
