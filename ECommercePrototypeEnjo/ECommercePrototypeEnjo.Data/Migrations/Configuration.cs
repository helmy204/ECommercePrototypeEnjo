namespace ECommercePrototypeEnjo.Data.Migrations
{
    using ECommercePrototypeEnjo.Core;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ECommercePrototypeEnjo.Data.ECommerceEnjoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ECommercePrototypeEnjo.Data.ECommerceEnjoContext";
        }

        protected override void Seed(ECommercePrototypeEnjo.Data.ECommerceEnjoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(
                    c => c.Id,
                        new Customer() { Id = 1, Username = "Customer1", Password = "P@ssw0rd", InsertedOn = DateTime.Now },
                        new Customer() { Id = 2, Username = "Customer2", Password = "P@ssw0rd", InsertedOn = DateTime.Now },
                        new Customer() { Id = 3, Username = "Customer3", Password = "P@ssw0rd", InsertedOn = DateTime.Now }
                );

            context.Products.AddOrUpdate(
                    p => p.Id,
                        new Product() { Id = 1, Thumbnail = "https://drive.google.com/uc?id=0BwHQ2cixpSzNdU1JMHBVUmNBMDA", Title = "Bathroom Combiwiper Fibre 28Cm", Price = 30, InsertedOn = DateTime.Now },
                        new Product() { Id = 2, Thumbnail = "https://drive.google.com/uc?id=0BwHQ2cixpSzNdU1JMHBVUmNBMDA", Title = "Bathroom Combiwiper Fibre 16Cm", Price = 50, InsertedOn = DateTime.Now },
                        new Product() { Id = 3, Thumbnail = "https://drive.google.com/uc?id=0BwHQ2cixpSzNelFhQlRCRjdDTHM", Title = "Bathroom Flexi Fibre 25Cm", Price = 8, InsertedOn = DateTime.Now },
                        new Product() { Id = 4, Thumbnail = null, Title = "Bathroom Wand Handle", Price = 33, InsertedOn = DateTime.Now },
                        new Product() { Id = 5, Thumbnail = null, Title = "Bathroom Wand Fibre", Price = 15, InsertedOn = DateTime.Now },
                        new Product() { Id = 6, Thumbnail = null, Title = "Bathroom Wand Set", Price = 64, InsertedOn = DateTime.Now },
                        new Product() { Id = 7, Thumbnail = "https://drive.google.com/uc?id=0BwHQ2cixpSzNckc2STlqNG04VkU", Title = "Bathroom Sponge", Price = 7, InsertedOn = DateTime.Now },
                        new Product() { Id = 8, Thumbnail = "https://drive.google.com/uc?id=0BwHQ2cixpSzNNkZzRl9ydV9IVXM", Title = "Bathroom Enjofil", Price = 12, InsertedOn = DateTime.Now },
                        new Product() { Id = 9, Thumbnail = "https://drive.google.com/uc?id=0BwHQ2cixpSzNeW1jVzFYYkdMemM", Title = "Bathroom Duocloth", Price = 30, InsertedOn = DateTime.Now }
                );

        }
    }
}
