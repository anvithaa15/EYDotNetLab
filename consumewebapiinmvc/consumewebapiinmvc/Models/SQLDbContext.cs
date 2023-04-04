using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace consumewebapiinmvc.Models
{
    public class SQLDbContext:DbContext
    {
        public SQLDbContext():base("name=sqlconn")
        {
        }
        public DbSet<employee> Employees { get; set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}