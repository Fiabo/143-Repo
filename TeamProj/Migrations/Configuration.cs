namespace TeamProj.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeamProj.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeamProj.Context context)
        {
            context.Salesmen.AddOrUpdate(
                p=>p.name,
                new Salesman { name="Amazon"},
                new Salesman { name="Apple"},
                new Salesman { name="Samsung"}
                );
            
           var sale1=context.Salesmen.Select(a=>a.name=="Amazon");
            var sale2=context.Salesmen.Where(a=>a.name=="Apple");
            var sale3=context.Salesmen.Where(a=>a.name=="Samsung");

            context.Good.AddOrUpdate(
                new Goods { name ="IPhone", salesman= context.Salesmen.Where(a=>a.name=="Apple").FirstOrDefault() },
                new Goods { name = "IPad", salesman = context.Salesmen.Where(a => a.name == "Apple").FirstOrDefault() },
                new Goods { name = "Galaxy S6", salesman = context.Salesmen.Where(a => a.name == "Samsung").FirstOrDefault() },
                new Goods { name = "Kindle", salesman = context.Salesmen.Where(a => a.name == "Amazon").FirstOrDefault() }                
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
