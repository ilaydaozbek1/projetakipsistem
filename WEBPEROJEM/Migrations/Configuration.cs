namespace WEBPEROJEM.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WEBPEROJEM.Models.DataContext.ProjeTakipDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//bu kısım da false yazıyordu bir otomoatik olarak değiştirmesini istediğimiz için true yaptık.
        }

        protected override void Seed(WEBPEROJEM.Models.DataContext.ProjeTakipDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
