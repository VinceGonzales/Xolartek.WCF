namespace Xolartek.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Xolartek.Domain.XolarDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Xolartek.Domain.XolarDatabase context)
        {
            if (context.Database.Exists())
            {
                //
            }
        }
    }
}
