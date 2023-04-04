//===================LINQ-basics-4======23/3/23=================
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace ConsoleApp1
//{
    //        class employee
    //        {
    //            public string Name { get; set; }
    //            public string EmpID { get; set; }

    //        }
    //        class worker
    //        {
    //            public string WId { get; set; }
    //            public string city { get; set; }
    //        }

    //    class linq4
    //    {
    //        static void Main(string[] args)
    //        {
    //            List<employee> objemployee = new List<employee>
    //            {
    //                new employee{Name="rahul",EmpID="I001"},
    //                new employee{Name="sharath",EmpID="I002"},
    //                new employee{Name="priya",EmpID="I003"},
    //                new employee{Name="anusha",EmpID="I004"},
    //                new employee{Name="vinay",EmpID="I005"},
    //            };
    //            List<worker> objworker = new List<worker>
    //            {
    //                new worker { WId = "I001", city = "Delhi" },
    //                new worker { WId = "I002", city = "Haridwar" },
    //                new worker { WId = "I007", city = "Roorkee" },
    //                new worker { WId = "I008", city = "Amritsar" },
    //                new worker { WId = "I009", city = "Delhi" },
    //            };
    //        //using DefaultIfEmpty-

    //            var resultDefaultEmpty = from emp in objemployee
    //                                     join worker in objworker
    //                                     on emp.EmpID equals worker.WId
    //                                     into ResultEmpWorker  //1,2

    //                                     from output in ResultEmpWorker.DefaultIfEmpty()
    //                                     select new
    //                                     {
    //                                         employeeName = emp.Name,
    //                                         city = output != null ? output.city : null
    //                                     };

    //            Console.WriteLine(string.Join("n",resultDefaultEmpty.Select(emp=>"Employee name= " +
    //            emp.employeeName+ ",\t City Name= " + emp.city).ToArray<string>()));

    //            Console.ReadLine();

    //        }
    //    }   
    //}

    //=====================Grouping Operators===============================
    //    class student
    //    {
    //        public string studname { get; set; }
    //        public int studID { get; set; }
    //        public int age { get; set; }

    //    }
    //    class prog
    //    {
    //        static void Main(string[] args)
    //        {
    //            IList<student> studentlist = new List<student>()
    //            {
    //                new student(){studID=1,studname="john",age=18},
    //                new student(){studID=2,studname="steve",age=21},
    //                new student(){studID=3,studname="bill",age=18},
    //                new student(){studID=4,studname="ram",age=28},
    //                new student(){studID=5,studname="abram",age=21},
    //            };

    //            var groupedResult = from s in studentlist
    //                                group s by s.age;

    //            //iterate each group-
    //            foreach (var ageGroup in groupedResult)
    //            {
    //                Console.WriteLine("age group :{0}", ageGroup.Key);//each group has a key
    //                foreach (student s in ageGroup)//each group has inner collection
    //                {
    //                    Console.WriteLine("student name :{0}", s.studname);
    //                }
    //            }
    //        }
    //    }
    //}

    //===================Join Operators=============================
    //------------------inner and left---------------------
    //public class employee1
    //{
    //    public int emp_id { get; set; }
    //    public string emp_name { get; set; }
    //    public string emp_lang { get; set; }
    //}
    //public class employee2
    //{
    //    public int emp_id { get; set; }
    //    public string emp_dept { get; set; }
    //    public int salary { get; set; }
    //}
    //class gfg
    //{
    //    //main method
    //    static void Main(string[] args)
    //    {
    //        List<employee1> emp1 = new List<employee1>()
    //        {
    //            new employee1() { emp_id = 300, emp_name = "anu", emp_lang = "c#" },
    //            new employee1() { emp_id = 301, emp_name = "mohit", emp_lang = "c" },
    //            new employee1() { emp_id = 302, emp_name = "sona", emp_lang = "java" },
    //            new employee1() { emp_id = 303, emp_name = "alana", emp_lang = "java" },
    //            new employee1() { emp_id = 304, emp_name = "lion", emp_lang = "c#" },
    //            new employee1() { emp_id = 305, emp_name = "ramona", emp_lang = "java" },
    //        };

    //        List<employee2> emp2 = new List<employee2>()
    //        {
    //            new employee2() { emp_id = 300, emp_dept = "designing", salary =23000 },
    //            new employee2() { emp_id = 301, emp_dept = "developer", salary =40000 },
    //            new employee2() { emp_id = 302, emp_dept = "HR", salary=50000 },
    //            new employee2() { emp_id = 303, emp_dept = "designing", salary=60000 },

    //        };
    //------------------inner join-------------------
    //query to find the name and salary of employees using inner join.
    //        var res = from e1 in emp1
    //                  join e2 in emp2
    //                  on e1.emp_id equals e2.emp_id
    //                  select new
    //                  {
    //                      Emp_name = e1.emp_name,
    //                      Emp_sal = e2.salary,
    //                      Emp_lang=e1.emp_lang
    //                  };
    //foreach (var i in res)
    //{
    //    Console.WriteLine("name is: " + i.Emp_name + "  " + "salary is: " + i.Emp_sal + "  " + "language is: " + i.Emp_lang);
    //}

    //----------------------left join---or left outer join-----------------
    //            var res = from e in emp1
    //                      join d in emp2
    //                      on e.emp_id equals d.emp_id into empids

    //                      from ed in empids.DefaultIfEmpty()
    //                      select new
    //                      {
    //                          EmployeeName = e.emp_name,
    //                          DeptName = ed == null ? "no department" : ed.emp_dept
    //                      };
    //            foreach(var i in res)
    //            {
    //                Console.WriteLine(i.EmployeeName + "\t | " + i.DeptName);
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //------------------cross join----(cartesian product)-----------------
    //    public class employee
    //    {
    //        public int emp_id { get; set; }
    //        public string emp_name { get; set; }
    //        public string emp_lang { get; set; }
    //        public int dpt_id { get; set; }
    //    }
    //    public class department
    //    {
    //        public int dpt_id { get; set; }
    //        public string emp_dept { get; set; }
    //    }
    //    class demo
    //    {
    //        static void Main(string[] args)
    //        {
    //            List<employee> emp = new List<employee>()
    //            {
    //                new employee() { emp_id = 101, emp_name = "amit", emp_lang = "java", dpt_id = 1 },
    //                new employee() { emp_id = 102, emp_name = "mohit", emp_lang = "c#", dpt_id = 2 },
    //                new employee() { emp_id = 103, emp_name = "sona", emp_lang = "java", dpt_id = 1 },
    //                new employee() { emp_id = 104, emp_name = "rita", emp_lang = "c++", dpt_id = 3 },
    //                new employee() { emp_id = 105, emp_name = "riya", emp_lang = "c#", dpt_id = 2 },
    //            };

    //            List<department> dpt = new List<department>()
    //            {
    //                new department() { dpt_id = 1, emp_dept = "designing" },
    //                new department() { dpt_id = 2, emp_dept = "development" },
    //                new department() { dpt_id = 3, emp_dept = "hr" }
    //            };

    //            //implementing cross join using query syntax-
    //            var res = from first in emp
    //                      from second in dpt
    //                      select new
    //                      {
    //                          Employee_name = first.emp_name,
    //                          Department_name = second.emp_dept
    //                      };

    //            //display results-
    //            foreach (var val in res)
    //            {
    //                Console.WriteLine("employee name: {0} || department name: {1}", val.Employee_name, val.Department_name);
    //            }
    //        }
    //    }
    //}

    //============================set operators========================
    //----------union-------intersect----except----distinct------------
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] count1 = { "UK", "Australia", "India", "India", "USA" };
    //        string[] count2 = { "India", "Canada", "UK","China" };

    //        Console.WriteLine("union demo:");
    //        var result = count1.Union(count2);
    //        foreach(var item in result)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        Console.WriteLine();

    //Console.WriteLine("intersect demo:");
    //var result1 = count1.Intersect(count2);
    //foreach(var i in result1)
    //{
    //    Console.WriteLine(i);
    //}
    //Console.WriteLine();

    //Console.WriteLine("distinct demo-1:");
    //var result2 = count1.Distinct();
    //foreach(var a in result2)
    //{
    //    Console.WriteLine(a);
    //}
    //Console.WriteLine();

    //Console.WriteLine("distinct demo-2:");
    //            string[] countries = { "UK", "uk", "Australia", "INDIA", "india", "USA" };
    //            IEnumerable<string> result3 = countries.Distinct(StringComparer.OrdinalIgnoreCase);
    //            foreach(var item in result3)
    //            {
    //                Console.WriteLine(item);
    //            }
    //            Console.WriteLine();

    //            Console.WriteLine("except demo:");
    //            string[] arr1 = { "aan", "momo", "vini", "shami" };
    //            string[] arr2 = { "rach", "appu", "arya", "vini", "shami" };
    //            var result4 = arr1.Except(arr2);
    //            foreach(var b in result4)
    //            {
    //                Console.WriteLine(b);
    //            }
    //            Console.WriteLine();

    //            Console.ReadLine();
    //        }
    //    }
    //}
//}          
