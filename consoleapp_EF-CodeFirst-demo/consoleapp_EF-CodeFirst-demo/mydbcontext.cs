using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace consoleapp_EF_CodeFirst_demo
{
    class mydbcontext : DbContext
    {
        public mydbcontext() : base("EYDbs")
        {
            Database.SetInitializer<mydbcontext>(new CreateDatabaseIfNotExists<mydbcontext>());
        }
        public DbSet<employee> employees {get;set;}
    }
}
