namespace codemigrationdemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<codemigrationdemo.models.employeecontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "codemigrationdemo.models.employeecontext";
        }

        protected override void Seed(codemigrationdemo.models.employeecontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
