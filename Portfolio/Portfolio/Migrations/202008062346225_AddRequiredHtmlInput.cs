namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredHtmlInput : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Entries", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Entries", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Entries", "Email", c => c.String());
            AlterColumn("dbo.Entries", "Name", c => c.String());
        }
    }
}
