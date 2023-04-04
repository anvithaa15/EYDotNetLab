using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp_EF_DBFirst_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var con=new EYDatabaseEntities5())
            {
                var result = con.customersses;
                foreach(var item in result)
                {
                    Console.WriteLine("customer id is "+item.customer_id);
                    Console.WriteLine("customer name is " + item.cust_name);
                    Console.WriteLine("city is " + item.city);
                    Console.WriteLine("grade is " + item.grade);
                    Console.WriteLine("salesman id " + item.salesman_id);
                }
                Console.ReadLine();
            }
        }
    }
}
