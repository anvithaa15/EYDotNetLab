using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codemigrationdemo.models;

namespace codemigrationdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new employeecontext())
            {
                //insert vals in database
                context.employees.Add(new employee { empid = 1, empname = "anusha" });
                context.employees.Add(new employee { empid = 2, empname = "anvitha" });
                context.employees.Add(new employee { empid = 3, empname = "amulya" });
                context.employees.Add(new employee { empid = 4, empname = "ankitha" });

                context.SaveChanges();

                //get all vals from database
                foreach (var emp in context.employees)
                {
                    Console.WriteLine("employees id : " + emp.empid);
                    Console.WriteLine("employee name : " + emp.empname);
                }
                Console.WriteLine("exit");
                Console.ReadLine();
            }
        }
    }
}
