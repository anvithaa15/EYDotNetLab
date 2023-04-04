//===================LINQ-basics-3======21/3/23=================
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    //==============sorting operators====================
    //    class student
    //    {
    //        public int studid { get; set; }
    //        public string studname { get; set; }
    //        public int age { get; set; }
    //    }
    //    class linq3
    //    {
    //        static void Main(string[] args)
    //        {
    //            IList<student> studentList = new List<student>() {
    //             new student(){studid=1,studname="ross",age=19},
    //             new student(){studid=2,studname="rachel",age=18},
    //             new student(){studid=3,studname="monica",age=18},
    //             new student(){studid=4,studname="joey",age=19},
    //             new student(){studid=5,studname="chandler",age=19},
    //             new student(){studid=6,studname="phoebe",age=19}
    //            };

    //            var thenbyresult = studentList.OrderBy(s => s.studname).ThenBy(s => s.age);

    //            var thenbydescresult = studentList.OrderBy(s => s.studname).ThenByDescending(s => s.age);

    //            Console.WriteLine("thenby:");
    //            foreach (var i in thenbyresult)
    //            {
    //                Console.WriteLine("name: {0}, age: {1}",i.studname,i.age);
    //            }

    //            Console.WriteLine("thenbydescending:");
    //            foreach (var i in thenbydescresult)
    //            {
    //                Console.WriteLine("name: {0}, age: {1}", i.studname, i.age);
    //            }

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //=================partition operator======================
    //--------take,takewhile,skip,skipwhile---------
    //    class myclass
    //    {
    //        static void Main(string[] args)
    //        {
    //            IList<string> strlist = new List<string>() { "one", "two", "three", "four", "five" };

    //            var newlist = strlist.Take(2);

    //            Console.WriteLine("take demo:");
    //            foreach (var str in newlist)
    //                Console.WriteLine(str);

    //            Console.WriteLine();

    //            IList<string> strlist1 = new List<string>() {"seven","two", "three", "fourhundred", "five" };

    //            var result = strlist1.TakeWhile(s => s.Length >=3);//if 1st element satisfies the condn., then it will move further and print. else,it will exit.

    //            Console.WriteLine("take while demo:");
    //            foreach(var str in result)
    //                Console.WriteLine(str);

    //            Console.WriteLine();

    //            Console.WriteLine("skip demo:");
    //            var newlist1 = strlist.Skip(2);

    //            foreach(var str in newlist1)
    //                Console.WriteLine(str);

    //            Console.WriteLine();

    //            IList<string> strlist2 = new List<string>() {"two", "three", "fourhundred", "five" };

    //            Console.WriteLine("skip while demo:");
    //            var result2 = strlist2.SkipWhile(s => s.Length < 4); //opp to takewhile. If 1st condn. is satisfied, it will skip and goes to next and prints.
    //            foreach(var str in result2)
    //                Console.WriteLine(str);

    //            Console.WriteLine();

    //            IList<int> num = new List<int>() { 15, 20, 25, 30, 35 };
    //            var res = num.Take(2);

    //            Console.WriteLine("take demo:");
    //            foreach (var r in res)
    //                Console.WriteLine(r);

    //            Console.WriteLine();

    //            IList<int> lis = new List<int>() { 15, 20, 25, 30, 35 };
    //            var res1 = lis.Skip(1);

    //            Console.WriteLine("skip demo:");
    //            foreach (var i in res1)
    //                Console.WriteLine(i);

    //            Console.WriteLine();

    //            IList<int> num1 = new List<int>() { 15,20,25,30,35 };

    //            var res2 = num1.TakeWhile(s => s>=15);//if 1st element satisfies the condn., then it will move further and print. else,it will exit.

    //            Console.WriteLine("take while demo:");
    //            foreach (var str in res2)
    //                Console.WriteLine(str);

    //            Console.WriteLine();

    //            IList<int> num2 = new List<int>() {5,10,15,20};

    //            Console.WriteLine("skip while demo:");
    //            var res3 = num2.SkipWhile(s =>s>5); //opp to takewhile. If 1st condn. is satisfied, it will skip and goes to next and prints.
    //            foreach (var str in res3)
    //                Console.WriteLine(str);

    //            Console.WriteLine();

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //====================conversion operators=====================================
    //-------------------TO:---toarray-tolist-------------------
    //class demo
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] countries = { "UK", "US", "India", "Australia", "China" };
    //        string[] countriesarray = countries.ToArray();

    //        foreach (var item in countriesarray)
    //        {
    //            Console.WriteLine(item);
    //        }

    //        Console.WriteLine();

    //        List<string> result = countries.ToList();
    //        foreach(string s in result)//used to print info of the countries
    //        {
    //            Console.WriteLine(s);
    //        }

    //        Console.ReadLine();
    //        }

    //    }
    //}

    //-----------------------tolookup---------------------------
    //    class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            //create an objemployee of class employee and create a list of employee
    //            List<employee> objemployee = new List<employee>()
    //            {
    //                new employee() { name = "akshay", department = "IT", country = "india" },
    //                new employee() { name = "vaishali", department = "marketing", country = "australia" },
    //                new employee() { name = "arpitha", department = "HR", country = "china" },
    //                new employee() { name = "shubham", department = "sales", country = "usa" },
    //                new employee() { name = "himanshu", department = "operations", country = "canada" },
    //            };

    //            //objemployee.ToLookup() method is used to print the value
    //            //of the data in the pair/collection of items.
    //            var emp = objemployee.ToLookup(x => x.department);

    //            Console.WriteLine("grouping employees by department");
    //            Console.WriteLine("--------------------------------");
    //            foreach (var keyvalpair in emp)
    //            {
    //                Console.WriteLine(keyvalpair.Key);
    //                //lookup employees by department
    //                foreach (var item in emp[keyvalpair.Key])
    //                {
    //                    Console.WriteLine("\t" + item.name + "\t" + item.department + "\t" + item.country);
    //                }
    //            }
    //            Console.ReadLine();
    //        }
    //        class employee
    //        {
    //            public string name { get; set; }
    //            public string department { get; set; }
    //            public string country { get; set; }
    //        }
    //    }
    //}

    //-------------------todictionary-----------------------
    //    class prog
    //    {
    //        static void Main(string[] args)
    //        {
    //            List<student> objstudent = new List<student>()
    //            {
    //                new student() {id=1,name="joey",gender="male",location="italy"},
    //                new student() {id=2,name="rachel",gender="female",location="usa"},
    //                new student() {id=3,name="monica",gender="female",location="mexico"},
    //                new student() {id=4,name="ross",gender="male",location="spain"},
    //                new student() {id=5,name="chandler",gender="male",location="canada"},
    //        };

    //            var student = objstudent.ToDictionary(x => x.id, x => x.name);

    //            foreach(var stud in student)
    //            {
    //                Console.WriteLine(stud.Key+"\t"+stud.Value);
    //            }
    //            Console.ReadLine();
    //    }
    //        class student
    //        {
    //            public int id { get; set; }
    //            public string name { get; set; }
    //            public string gender { get; set; }
    //            public string location { get; set; }
    //        }
    //    }
    //}

    //    //---------------------AS:---asenumerable---(1)-----------------
    //    class prog
    //    {
    //        static void Main(string[] args)
    //        {
    //            int[] numarr = new int[] { 1, 2, 3, 4, 5 };

    //            var res = numarr.AsEnumerable();
    //            foreach (var i in res)
    //            {
    //                Console.WriteLine(i);
    //            }
    //            Console.WriteLine();

    //            //-------------------AS:---asqueryable--------------------
    //            //list and array can be converted ti Ioueryable.
    //            List<int> list = new List<int>();
    //            list.Add(0);
    //            list.Add(1);

    //            int[] array = new int[2];
    //            array[0] = 0;
    //            array[1] = 1;

    //            //we can use IQueryable to treat collections with one type.
    //            test(list.AsQueryable());
    //            test(array.AsQueryable());


    //            static void test(IQueryable<int> items)
    //            {
    //                Console.WriteLine($"Average: {items.Average()}");
    //                Console.WriteLine($"Sum: {items.Sum()}");
    //            }

    //            Console.ReadLine();
    //        }
    //    }
    //}
    //-------------------AS:---asenumerable------(2)--------------
}


