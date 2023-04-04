using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codemigrationdemo.models
{
    public class employeecontext:DbContext
    {
        public employeecontext() : base("myconn") 
        { 
        
        }
        public DbSet<employee> employees { get; set; }
    }
    public class employee
    {
        [Key]
        public int empid { get; set; }
        public string empname { get; set; }
        public string role { get; set; }
        public string empaddress { get; set; }
    }
}
