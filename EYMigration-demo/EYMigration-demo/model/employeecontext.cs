using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EYMigration_demo.model
{
    public class employeecontext :DbContext
    {
        public DbSet<employee> employees { get; set; }
    }
    public class employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
    }
}
