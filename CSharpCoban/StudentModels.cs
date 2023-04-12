using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoban
{
    public class StudentModels: DbContext
    {
        public StudentModels() : base("ManagerStudent1")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<StudentModels>());

            // var initializer = new MigrateDatabaseToLatestVersion<StudentModels, Migrations.Configuration>(); 
            //Database.SetInitializer(initializer);
        }

      

        public virtual DbSet<Product> product { get; set; }

    }
}
