//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EYDotNetDay2
//{
//class P23
//{
//    static void Main(string[] args)
//    {
//        Stack<string> s1 = new Stack<string>();
//        s1.Push("aa");
//        s1.Push("bb");
//        s1.Push("cc");
//        s1.Push("dd");

//        Console.WriteLine("Stack(strings)  elements are : ");
//        foreach(var item in s1)
//        {
//            Console.WriteLine(item);
//        }

//        Stack<int> sl1 = new Stack<int>();
//        sl1.Push(10);
//        sl1.Push(11);
//        sl1.Push(12);
//        sl1.Push(13);

//        Console.WriteLine("stack(int) elements are: ");
//        foreach(var item in sl1)
//        {
//            Console.WriteLine(item);
//        }

//        Queue<int> q = new Queue<int>();
//        q.Enqueue(15);
//        q.Enqueue(16);
//        q.Enqueue(17);
//        q.Enqueue(18);

//        Console.WriteLine("queue elements are: ");
//        foreach (var item in q)
//        {
//            Console.WriteLine(item);
//        }

//        SortedList<int, string> sl = new SortedList<int, string>();
//        sl.Add(10, "aa");
//        sl.Add(11, "bb");
//        sl.Add(12, "cc");

//        Console.WriteLine("sorted list elements are: ");
//        foreach (var item in sl)
//        {
//            Console.WriteLine(item);
//        }

//        LinkedList<int> l = new LinkedList<int>();
//        l.AddLast(19);
//        l.AddFirst(20);
//        //l.Remove(19);
//        //l.RemoveFirst();
//        //l.RemoveLast();

//        var node1 = l.AddLast(1000);
//        l.AddBefore(node1, 1000);
//        l.RemoveLast();
//        Console.WriteLine("linked list elements are: ");
//        foreach(var item in l)
//        {
//            Console.WriteLine(item);
//        }

//        Console.ReadLine();
//    }
//}
//}

//    class list
//    {
//        static void Main(string[] args)
//        {
//            LinkedList<int> m = new LinkedList<int>();
//            m.AddLast(9);
//            m.AddLast(8);
//            m.AddLast(7);
//            m.AddLast(6);
//            m.AddLast(5);

//            var node = m.AddLast(10);// to add 10 after 7
//            m.AddAfter(node,7);

//            m.AddLast(11);

//            Console.WriteLine("list elements are: ");
//            foreach (var item in m)
//            {
//                Console.WriteLine(item);
//            }
//            Console.ReadLine();
//        }
//    }
//}

//=========================================================================
//Exception handling-------------------------------------------------------

//    class ex1
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine("enter 1st number: ");
//                int num1 = int.Parse(Console.ReadLine());

//                Console.WriteLine("enter 2nd number: ");
//                int num2 = int.Parse(Console.ReadLine());

//                float result = num1 / num2;
//                Console.WriteLine("division result is: " + result);
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            //catch (DivideByZeroException ex)
//            //{
//            //    Console.WriteLine(ex.Message);
//            //}
//            finally
//            {
//                Console.WriteLine("finally will always execute");
//            }

//            Console.ReadLine();
//        }
//    }
//}

//try
//{
//    string a = null;
//    Console.WriteLine(a[0]);
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine("All exception block");
//}

//static void Main(string[] args)
//{
//    var divider = 0;

//    try
//    {
//        try
//        {
//            var result = 100 / divider;
//        }
//        catch
//        {
//            Console.WriteLine("Inner catch");
//        }
//    }
//    catch
//    {
//        Console.WriteLine("Outer catch");
//    }
//}
//-------------------------------------n
//try
//{
//    int[] a = new int[4];
//    Console.WriteLine(a[5]);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine("All exception block");
//}