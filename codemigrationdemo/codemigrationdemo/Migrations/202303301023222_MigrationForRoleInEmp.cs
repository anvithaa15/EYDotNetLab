namespace codemigrationdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationForRoleInEmp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.employees", "role", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.employees", "role");
        }
    }
}
