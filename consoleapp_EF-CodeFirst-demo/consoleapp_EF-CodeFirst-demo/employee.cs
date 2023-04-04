using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace consoleapp_EF_CodeFirst_demo
{
    class employee
    {
        public employee()
        {
        }           
        [Key] 
        public int empid { get; set; }
        public string empname { get; set; }
        public string empaddress { get; set; }
    }   
}


