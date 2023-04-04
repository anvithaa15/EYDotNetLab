using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp_EF_CodeFirst_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            mydbcontext context = new mydbcontext();

            employee emp = new employee() { empid = 500, empname = "anvitha", empaddress = "bangalore" };

            context.employees.Add(emp);

            context.SaveChanges();
            Console.WriteLine("success");
            Console.ReadLine();
        }
    }
}
