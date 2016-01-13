namespace TeamProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        salesman_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Salesmen", t => t.salesman_id)
                .Index(t => t.salesman_id);
            
            CreateTable(
                "dbo.Salesmen",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goods", "salesman_id", "dbo.Salesmen");
            DropIndex("dbo.Goods", new[] { "salesman_id" });
            DropTable("dbo.Salesmen");
            DropTable("dbo.Goods");
        }
    }
}
