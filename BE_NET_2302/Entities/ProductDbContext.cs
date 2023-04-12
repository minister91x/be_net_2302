using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BE_NET_2302.Entities
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext() : base("ManagerProduct")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<ProductDbContext>());

            var initializer = new MigrateDatabaseToLatestVersion<ProductDbContext, Migrations.Configuration>();
            Database.SetInitializer(initializer);
        }
        public virtual DbSet<Product> product { get; set; }
        public virtual DbSet<Orders> order { get; set; }
    }
}