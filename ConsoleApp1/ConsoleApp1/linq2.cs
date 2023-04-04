//===================LINQ-basics-2======20/3/23=================
//using System;
//using System.Collections.Generic;
//using System.Collections;
//using System.Text;
//using System.Linq;

//namespace ConsoleApp1
//{
    //    class linqoperatorDemo
    //    {
    //        static void Main(string[] args)
    //        {
    //            int[] numbers = { 5, 10, 15, 20, 25, 30, 35 };
    //            var result = numbers.Where(n => n >= 15 && n < 25);

    //            //int n;
    //            //if(n>=15&&n<=25)

    //            Console.WriteLine("numbers being >=15 and <=25:");
    //            foreach(var number in result)
    //            {
    //                Console.WriteLine(number);
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //===================element operator====================================
    //class myclass
    //{
    //        static void Main(string[] args)
    //        {
    //            string[] words = { "falcon", "oak", "sky", "cloud", "tree", "tea", "water" };

    //            Console.WriteLine("elements at: " + words.ElementAt(2));
    //            Console.WriteLine("words.first() :" + words.First());
    //            Console.WriteLine("words.last() :" + words.Last());

    //            Console.WriteLine("words.first(word=>word.length==3) :" + words.First(words => words.Length == 3));
    //            Console.WriteLine("words.last(word=>word.length==3) :" + words.Last(words => words.Length == 3));

    //            Console.ReadLine();

    //        }
    //    }
    //}
    //==========================================================
    //    class demo
    //    {
    //        static void Main(string[] args)
    //        {
    //            int[] vals = { 1, 2, 3 };
    //            vals.Prepend(0);
    //            vals.Append(4);

    //            Console.WriteLine(string.Join(",", vals));

    //            var vals2 = vals.Prepend(0);   //var, object
    //            var vals3 = vals.Append(4);

    //            Console.ReadLine();
    //        }
    //    }
    //}
    //========================================
    //    class example
    //    {
    //        static void Main(string[] args)
    //        {
    //            int[] vals = { 2, 4, 6, 8 };

    //            var powered = vals.Select(e => Math.Pow(e, 2));
    //            Console.WriteLine(string.Join(",", powered));

    //            string[] words = { "sky", "earth", "oak", "falcon" };
    //            var wordlens = words.Select(e => e.Length);
    //            Console.WriteLine(string.Join(",", wordlens));

    //            Console.ReadLine();

    //        }
    //    }
    //}
    //=============================================
    //    class student
    //    {
    //        public int Studid { get; set; }
    //        public string Studname { get; set; }
    //    }
    //    class prog
    //    {
    //        static void Main(string[] args)
    //        {
    //            IList mixedlist = new ArrayList();

    //            mixedlist.Add(0);
    //            mixedlist.Add("one");
    //            mixedlist.Add("two");
    //            mixedlist.Add(3);
    //            mixedlist.Add(new student() { Studid = 1, Studname = "rachel" });

    //            var stringResult = from s in mixedlist.OfType<string>()
    //                               select s;

    //            var intResult = from s in mixedlist.OfType<int>()
    //                               select s;

    //            Console.WriteLine("printing string result using for each loop");
    //            foreach (var i in stringResult)
    //            {
    //                Console.WriteLine(i);
    //            }

    //            Console.WriteLine("printing string result using string join");
    //            Console.WriteLine(String.Join(",", stringResult));

    //            Console.ReadLine();
    //        }
    //    }
    //}
    //==================================================================

//    Ilist<student> studentlist=new Ilist<student>()
//    {

//    }
//class student
//    {
//        public int studentid { get; set; }
//        public string studname { get; set; }
//        public int standardid { get; set; }
//    }

//    class standard
//    {
//        public int standardid { get; set; }
//        public string standardname { get; set; }
//    }
//}

