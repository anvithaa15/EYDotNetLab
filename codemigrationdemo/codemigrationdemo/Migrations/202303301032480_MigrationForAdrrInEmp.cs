namespace codemigrationdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationForAdrrInEmp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.employees", "empaddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.employees", "empaddress");
        }
    }
}
