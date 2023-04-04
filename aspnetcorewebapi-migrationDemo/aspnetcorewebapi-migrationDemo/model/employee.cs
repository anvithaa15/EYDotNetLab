using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace aspnetcorewebapi_migrationDemo.model
{
    public class employee
    {
        [Key]
        public int empid { get; set; }
        public string empfirstName { get; set; }
        public string emplastName { get; set; }
    }
}
