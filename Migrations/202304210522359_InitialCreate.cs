namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.roles",
                c => new
                    {
                        roleId = c.Int(nullable: false, identity: true),
                        roleName = c.String(),
                    })
                .PrimaryKey(t => t.roleId);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        userName = c.String(),
                        password = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.String(),
                        DOB = c.DateTime(),
                        email = c.String(),
                        roleId = c.Int(),
                    })
                .PrimaryKey(t => t.userId)
                .ForeignKey("dbo.roles", t => t.roleId)
                .Index(t => t.roleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.users", "roleId", "dbo.roles");
            DropIndex("dbo.users", new[] { "roleId" });
            DropTable("dbo.users");
            DropTable("dbo.roles");
        }
    }
}
