//using System;
//using System.Linq;
//using System.Collections.Generic;

////========LINQ Basics-1-===========17/3/23
//namespace ConsoleApp1
//{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //Console.WriteLine("Hello World!");

    //Console.WriteLine("list of names are: ");
    //string[] arr = { "anvitha", "rachana", "pavan", "madhu" };
    //for(int i = 0; i < 4; i++)
    //{
    //    //Console.WriteLine(i);
    //    Console.WriteLine(arr[i]);
    //}

    //---single dimensional array
    //int[] a = new int[4] { 2, 4, 6, 8 };
    //for(int i = 0; i < a.Length; i++)
    //{
    //    Console.WriteLine(a[i]);
    //}

    //----strings------
    //Console.WriteLine("list of names are: ");
    //string[] arr = { "anvitha", "rachana","amulya", "pavan", "madhu" };
    //for (int i = 0; i < 4; i++)
    //{
    //    //Console.WriteLine(i);
    //    Console.WriteLine(arr[i]);
    //}
    ////linq query examples----
    //var query1 = from i in arr
    //             where i.StartsWith('a')
    //             select i;

    //Console.WriteLine("list of names starting with letter a:");
    //foreach(var item in query1)
    //{
    //    Console.WriteLine(item);
    //}
    ////================================================
    //var query2 = from i in arr
    //             where i.Contains('a')
    //             select i;
    //Console.WriteLine("list of names containing letter a:");
    //foreach (var item in query2)
    //{
    //    Console.WriteLine(item);
    //}
    ////=================================================
    //var query3 = from i in arr
    //             where i.Length == 6
    //             select i;
    //Console.WriteLine("list of names whose length is 6:");
    //foreach (var item in query3)
    //{
    //    Console.WriteLine(item);
    //}
    ////===================================================
    //var query4 = from i in arr
    //             where i.EndsWith('u')
    //             select i;
    //Console.WriteLine("list of names ending with u: ");
    //foreach (var item in query4)
    //{
    //    Console.WriteLine(item);
    //}
    ////=======================================================
    //var query5 = from i in arr
    //             where i.Contains('p')
    //             select i;
    //Console.WriteLine("list of names ending with u: ");
    //foreach (var item in query5)
    //{
    //    Console.WriteLine(item);
    //}
    //======================================================

    //-----integers------
    //int[] arr = { 8, 3, 5, 9, 21, 56 };

    //var query1 = from i in arr
    //             //where i > 5
    //             //where i<5
    //             //where i>5&&i<=25
    //             //where i>=5&&i<=50
    //             select i;

    //Console.WriteLine("list of numbers are: ");
    //foreach(var item in query1)
    //{
    //    Console.WriteLine(item);
    //}

    //----aggregate functions----
    //int[] arr = { 8, 3, 5, 87, 12, 67, 34, 45 };

    //int result1 = arr.Count();
    //Console.WriteLine("total number of elements :{0}",result1);

    //int result2 = arr.Max();
    //Console.WriteLine("max number of elements :{0}", result2);

    //int result3 = arr.Min();
    //Console.WriteLine("min number of elements :{0}", result3);

    //int result4 = arr.Sum();
    //Console.WriteLine("sum number of elements :{0}", result4);

    //double result5 = arr.Average();
    //Console.WriteLine("average of elements :{0}", result5);

    //    Console.ReadLine();
    //}

    //----------------------program--------------------------------------------------------
    //employee details
    //public class employee
    //{
    //    public int empid { get; set; }
    //    public string empname { get; set; }
    //    public string empgender { get; set; }
    //    public string emphireDate { get; set; }
    //    public int empsal { get; set; }
    //}
    //class gfg
    //{
    //    //main method
    //    static void Main(string[] args)
    //    {
    //        List<employee> emp = new List<employee>()
    //        {
    //            new employee(){empid=200,empname="harsha",empgender="male",emphireDate="12/3/2022",empsal=40000},
    //            new employee(){empid=201,empname="anvitha",empgender="female",emphireDate="13/5/2022",empsal=55000},
    //            new employee(){empid=202,empname="bhoomika",empgender="female",emphireDate="23/6/2022",empsal=30000},
    //            new employee(){empid=203,empname="rachana",empgender="female",emphireDate="26/8/2022",empsal=37000},
    //            new employee(){empid=204,empname="rahul",empgender="male",emphireDate="15/3/2023",empsal=46000},
    //        };

    //        //count total num of employees count method()-
    //        var res = (from e in emp
    //                   select e.empid)
    //                   .Count();

    //        Console.WriteLine("total num of employees: {0}",res);

    //        //get the max num of employees max method()-
    //        var res1 = (from e in emp
    //                   select e.empid)
    //                   .Max();

    //        Console.WriteLine("maximum id of employee: {0}", res1);

    //        //min num of employees, min method()-
    //        var res2 = (from e in emp
    //                    select e.empid)
    //                   .Min();

    //        Console.WriteLine("minimum id of employee: {0}", res2);

    //        //avg num of employees, average method()-
    //        var res3 = (from e in emp
    //                    select e.empsal)
    //                   .Min();

    //        Console.WriteLine("average num of employees salary: {0}", res3);

    //        //sum of employees sal, sum method()-
    //        var res4 = (from e in emp
    //                    select e.empsal)
    //                   .Sum();

    //        Console.WriteLine("sum of employees salaries: {0}", res4);
    //    }
    //}

    //=========================================================================================
    //---------------projection operator----------------
    //public class employee
    //{
    //    public int empid { get; set; }
    //    public string empname { get; set; }
    //    public string empgender { get; set; }
    //    public string emphireDate { get; set; }
    //    public int empsal { get; set; }
    //}
    //class gfg
    //{
    //    static void Main(string[] args)
    //    {
    //        List<employee> emp = new List<employee>()
    //        {
    //            new employee(){empid=200,empname="harsha",empgender="male",emphireDate="12/3/2022",empsal=40000},
    //            new employee(){empid=201,empname="anvitha",empgender="female",emphireDate="13/5/2022",empsal=55000},
    //            new employee(){empid=202,empname="bhoomika",empgender="female",emphireDate="23/6/2022",empsal=30000},
    //            new employee(){empid=203,empname="rachana",empgender="female",emphireDate="26/8/2022",empsal=37000},
    //            new employee(){empid=204,empname="rahul",empgender="male",emphireDate="15/3/2023",empsal=46000},
    //        };

    //var query1 = from i in emp
    //             select i.empname;
    //Console.WriteLine("employee details :");
    //foreach(var item in query1)
    //{
    //    Console.WriteLine(item);
    //}

    //,,,,,,,,,,,,,,,,,,,,,,,,
    //var selectResult = from s in emp
    //                   select new { Name = "Mr. " + s.empname, Gender = s.empgender };
    ////iterate selectResult
    //foreach(var item in selectResult)
    //{
    //    Console.WriteLine("Employee name: {0}, Gender is :{1}",item.Name,item.Gender);
    //}
    //Console.ReadLine();

    //,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
    //lambda expression-
    //            var selectResult1 = emp.Select(s=>new{ Name=s.empname, Gender=s.empgender });
    //            foreach (var item in selectResult1)
    //            {
    //                Console.WriteLine("Employee name: {0}, Gender is :{1}", item.Name, item.Gender);
    //            }

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //------------------------------
    //    class country
    //    {
    //        public string name { get; set; }
    //        public string language { get; set; }
    //    }
    //    class Myclass
    //    {
    //        static void Main(string[] args)
    //        {
    //            IList<country> obj = new List<country>();
    //            obj.Add(new country() { name = "india", language = "english" });
    //            obj.Add(new country() { name = "usa", language = "english" });
    //            obj.Add(new country() { name = "uk", language = "english" });
    //            obj.Add(new country() { name = "spain", language = "spanish" });
    //            obj.Add(new country() { name = "russia", language = "russian" });
    //            obj.Add(new country() { name = "dubai", language = "arabic" });

    //            var countryNames =
    //                obj.Where(c => c.language == "english").Select(s => s.name);//query for getting english speaking countries.

    //            foreach (var cn in countryNames)
    //            {
    //                Console.WriteLine("country : {0}", cn);
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}
//}


