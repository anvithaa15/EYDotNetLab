namespace codemigrationdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employees",
                c => new
                    {
                        empid = c.Int(nullable: false, identity: true),
                        empname = c.String(),
                    })
                .PrimaryKey(t => t.empid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.employees");
        }
    }
}
