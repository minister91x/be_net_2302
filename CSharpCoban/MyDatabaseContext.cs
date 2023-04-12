using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class MyDatabaseContext: DbContext
    {
       
        public MyDatabaseContext() : base("ManagerProduct")
        {
           Database.SetInitializer(new DropCreateDatabaseAlways<MyDatabaseContext>());

            //var initializer = new MigrateDatabaseToLatestVersion<MyDatabaseContext, Migrations.Configuration>();
            //Database.SetInitializer(initializer);
        }
       public virtual DbSet<Product> product { get; set; }
       public virtual DbSet<Orders> order { get; set; }
    }
}
