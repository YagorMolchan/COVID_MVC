namespace COVID_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sicks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Plea = c.String(),
                        PaymentMethod = c.String(),
                        Area_Id = c.Int(),
                        Town_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.Area_Id)
                .ForeignKey("dbo.Towns", t => t.Town_Id)
                .Index(t => t.Area_Id)
                .Index(t => t.Town_Id);
            
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sicks", "Town_Id", "dbo.Towns");
            DropForeignKey("dbo.Sicks", "Area_Id", "dbo.Areas");
            DropIndex("dbo.Sicks", new[] { "Town_Id" });
            DropIndex("dbo.Sicks", new[] { "Area_Id" });
            DropTable("dbo.Volunteers");
            DropTable("dbo.Towns");
            DropTable("dbo.Sicks");
            DropTable("dbo.Areas");
        }
    }
}
