namespace TeamProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class REq : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Salesmen", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Salesmen", "name", c => c.String());
        }
    }
}
