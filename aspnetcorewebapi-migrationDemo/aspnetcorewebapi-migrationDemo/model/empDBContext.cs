using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aspnetcorewebapi_migrationDemo.model
{
    public class empDBContext:DbContext
    {
        public empDBContext(DbContextOptions options) : base(options) { }
        public DbSet<employee> employees { get; set; }
    }
}
