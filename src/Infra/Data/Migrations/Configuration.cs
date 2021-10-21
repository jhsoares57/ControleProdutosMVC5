using Infra.Data.Context;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Infra.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<ControleProdutoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        //protected override void Seed(Infra.Data.Context.ControleProdutoDbContext context)
        //{
        //    //  This method will be called after migrating to the latest version.

        //    //  You can use the DbSet<T>.AddOrUpdate() helper extension method
        //    //  to avoid creating duplicate seed data.
        //}
    }
}
