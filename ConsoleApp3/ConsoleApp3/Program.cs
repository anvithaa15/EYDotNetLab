using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        int customer_id;
        string cust_name;
        string city;
        int grade;
        //int salesman_id;
        public void insert()
        {
            Program p = new Program();

            Console.WriteLine("Enter customer_id");
            p.customer_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            p.cust_name = Console.ReadLine();

            Console.WriteLine("Enter city");
            p.city = Console.ReadLine();

            Console.WriteLine("Enter grade");
            p.grade = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter salesman_id");
            //int salesman_id = Convert.ToInt32(Console.ReadLine());

            DataClasses2DataContext LTS = new DataClasses2DataContext(@"Data Source=Lab-Host\SQLEXPRESS03;Initial Catalog=EYDatabase;Integrated Security=True");

            customerss obj = new customerss();
            obj.customer_id = p.customer_id;
            obj.cust_name = p.cust_name;
            obj.city = p.city;
            obj.grade = p.grade;
            //obj.salesman_id = p.salesman_id;

            LTS.customersses.InsertOnSubmit(obj);
            LTS.SubmitChanges();

            Console.WriteLine("insertion succesfull");
            Console.WriteLine();
        }

        public void display()
        {
            DataClasses2DataContext LTS = new DataClasses2DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03;Initial Catalog=EYDatabase;Integrated Security=True");

            var selectQuery = from s in LTS.customersses
                              select s;

            foreach(customerss s in selectQuery)
            {
                Console.WriteLine(s.customer_id+"\t"+s.cust_name+"\t"+s.city+"\t"+s.grade+"\t");
            }
            Console.WriteLine("display succesful");
            Console.WriteLine();
        }

        public void delete()
        {
            int iid = 0;
            Console.WriteLine("enter the id you want to delete:");
            iid = Convert.ToInt32(Console.ReadLine());

            DataClasses2DataContext LTS = new DataClasses2DataContext(@"Data Source=Lab-Host\SQLEXPRESS03;Initial Catalog=EYDatabase;Integrated Security=True");

            var delete = from p in LTS.customersses
                         where p.customer_id == iid
                         select p;

            LTS.customersses.DeleteAllOnSubmit(delete);
            LTS.SubmitChanges();

            Console.WriteLine("deletion succesful");
            Console.WriteLine();
        }
        public void Update()
        {
            
            int id = 0;
            string name;
            Console.WriteLine("enter the employee id inorder to update");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the new name to update");
            name = Console.ReadLine();
            
            DataClasses2DataContext LTS = new DataClasses2DataContext(@"Data Source=Lab-Host\SQLEXPRESS03;Initial Catalog=EYDatabase;Integrated Security=True");
            var row = from s in LTS.customersses
                      select s;
            foreach (customerss s in row)
            {

                if (s.customer_id == id)
                {
                    s.cust_name = name;
                }
            }
            LTS.SubmitChanges();
            Console.WriteLine("updated successfully");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.insert();
            p1.display();
            p1.delete();
            p1.Update();

            Console.ReadLine();
        }
    }
}




        
