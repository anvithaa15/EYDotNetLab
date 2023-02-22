//using System;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace EYDotNetLab
//{
    //    class JaggedArray
    //    {
    //        static void Main(string[] args)
    //        {
    //            int[][] arr = new int[2][];
    //            arr[0] = new int[] { 1, 2, 3, 4 };
    //            arr[1] = new int[] { 2, 3, 4 };
    //            for(int i = 0; i < arr.Length; i++)
    //            {
    //                for(int j = 0; j < arr[i].Length; j++)
    //                {
    //                    Console.WriteLine(arr[i][j]+ "  ");
    //                }
    //                Console.WriteLine();
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //=========================================================
    //COLLECTIONS-Non-generic---------------------

    //    class Stack1
    //    {
    //        static void Main(string[] args)
    //        {
    //            Stack s1 = new Stack();
    //            s1.Push(1);
    //            s1.Push(22);
    //            s1.Push(3);
    //            s1.Push(45);
    //            s1.Push(15);
    //            s1.Push(88);

    //            Console.WriteLine("stack elements are: ");
    //            foreach (int i in s1)
    //            {
    //                Console.WriteLine(i);
    //            }
    //            Console.WriteLine("stack count is: " + s1.Count);
    //            //s1.Clear();-clears all items in stack

    //            s1.Pop();
    //            Console.WriteLine("stack elements after pop are: ");
    //            foreach (dynamic i in s1)
    //            {
    //                Console.WriteLine(i); ;
    //            }
    //            Console.WriteLine("stack top most element is: " + s1.Peek());

    //            Stack s2 = new Stack();
    //            s2.Push('a');
    //            s2.Push("anvitha");
    //            s2.Push(234.76f);
    //            s2.Push(1000);

    //            Console.WriteLine("stack 2 elements are : ");
    //            foreach (var i in s2)
    //            {
    //                Console.WriteLine(i);
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //--------------------------------------------------

    //class Queue1
    //{
    //    static void Main(string[] args)
    //    {
    //        Queue s1 = new Queue();
    //        s1.Enqueue(1);
    //        s1.Enqueue(22);
    //        s1.Enqueue(3);
    //        s1.Enqueue(45);
    //        s1.Enqueue(15);
    //        s1.Enqueue(88);

    //        Console.WriteLine("queue elements are: ");
    //        foreach (int i in s1)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        Console.WriteLine("queue count is: " + s1.Count);
    //        //s1.Clear();-clears items in queue

    //        s1.Dequeue();
    //        Console.WriteLine("queue elements after dequeue are: ");
    //        foreach (dynamic i in s1)
    //        {
    //            Console.WriteLine(i); ;
    //        }
    //        Console.WriteLine("queue top most element is: " + s1.Peek());

    //        Queue s2 = new Queue();
    //        s2.Enqueue('a');
    //        s2.Enqueue("anvitha");
    //        s2.Enqueue(234.76f);
    //        s2.Enqueue(1000);

    //        Console.WriteLine("queue 2 elements are : ");
    //        foreach (var i in s2)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    //}

    //------------------------------------------------------

    //class arrayList1
    //{
    //    static void Main(string[] args)
    //    {
    //        ArrayList arr = new ArrayList();
    //        arr.Add(1);
    //        arr.Add(22);
    //        arr.Add(15);
    //        arr.Add(33);
    //        arr.Add(40);
    //        //addrange demo-1d array
    //        int[] myarray = new int[5] { 2, 3, 4, 5, 6 };
    //        arr.AddRange(myarray);
    //        Console.WriteLine("array elements are: ");
    //        foreach (var i in arr)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        //addrange demo2-another arrayList
    //        ArrayList arraylist1 = new ArrayList();
    //        arraylist1.Add(101);
    //        arraylist1.Add(102);
    //        arraylist1.Add(103);
    //        arr.AddRange(arraylist1);
    //        Console.WriteLine("array elements are: ");
    //        foreach(var i in arr)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        //contains demo-
    //        Console.WriteLine(arr.Contains(15));
    //        Console.WriteLine(arr.Contains(9));

    //Console.WriteLine("ArrayList elements are :");
    //foreach (var item in arr)
    //{
    //    Console.WriteLine(item);
    //}

    //arr.Sort();
    //Console.WriteLine("Arraylist elements after sort are :");
    //foreach (var item in arr)
    //{
    //    Console.WriteLine(item);
    //}

    //arr.Reverse();
    //Console.WriteLine("Arraylist elements after reverse are :");
    //foreach (var item in arr)
    //{
    //    Console.WriteLine(item);
    //}

    ////Console.ReadLine();

    //arr.Remove(0);
    //arr.RemoveAt(1);
    //arr.RemoveRange(0, 2);
    //Console.WriteLine("After removing :");
    //foreach (var item in arr)
    //{
    //    Console.WriteLine(item);
    //}

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //------------------------------------------------------------

    //    class hashtable1
    //    {
    //        static void Main(string[] args)
    //        {
    //            Hashtable ht = new Hashtable();
    //            ht.Add(1, "china");
    //            ht.Add(2, "india");
    //            ht.Add(3, "japan");

    //            Console.WriteLine("hash table elements are :");
    //            foreach (DictionaryEntry item in ht)
    //            {
    //                Console.WriteLine(item.Key + "   " + item.Value);
    //            }
    //            //ht.Clear(); clears all items
    //            Console.WriteLine("hashtable count is : " + ht.Count);

    //            ht.Remove(2);
    //            Console.WriteLine("hash table elements after remove are : ");
    //            foreach (DictionaryEntry item in ht)
    //            {
    //                Console.WriteLine(item.Key + "  " + item.Value);
    //            }

    //            Console.WriteLine(ht.Contains(1));
    //            Console.WriteLine(ht.ContainsKey(2));
    //            Console.WriteLine(ht.ContainsValue("india"));

    //            if (ht.IsFixedSize == true)
    //            {
    //                Console.WriteLine("fixed");
    //            }
    //            else
    //                Console.WriteLine("not fixed");
    //            cw(ht.isfixedsize);->gives bool val-(false)

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //-----------------------------------------------------

    //    class sortedlist1
    //    {
    //        static void Main(string[] args)
    //        {
    //            SortedList s1 = new SortedList();
    //            s1.Add("1", "c");
    //            s1.Add("2", "c#");
    //            s1.Add("3", "java");
    //            s1.Add("4", "html");
    //            s1.Add("5", "css");

    //            Console.WriteLine("sorted list elements are: ");
    //            foreach (DictionaryEntry item in s1)
    //            {
    //                Console.WriteLine((item.Key + "   " + item.Value));
    //            }

    //            //s1.clear(); clears items
    //            Console.WriteLine("sorted table count is : " + s1.Count);

    //            //s1.Remove(2);
    //            Console.WriteLine("sorted table elements after remove are : ");
    //            foreach (DictionaryEntry item in s1)
    //            {
    //                Console.WriteLine(item.Key + "  " + item.Value);
    //            }

    //            //s1.Remove(5);
    //            s1.RemoveAt(3);
    //            Console.WriteLine("After removing :");
    //            foreach (DictionaryEntry item in s1)
    //            {
    //                Console.WriteLine(item.Key + "  " + item.Value);
    //            }

    //            //Console.WriteLine(s1.Contains(5));
    //            //Console.WriteLine(s1.ContainsKey(4));
    //            Console.WriteLine(s1.ContainsValue("css"));

    //            Console.ReadLine();
    //        }
    //    }
    //}

//==============================================================
//COLLECTIONS-Generic class------------------------------------------

using System;
using System.Collections.Generic;
namespace CSharpProgram
{
    //    class A<T>
    //    {
    //        public A (T msg)
    //        {
    //            Console.WriteLine(msg);
    //        }
    //    }

    //    class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            A<string> gen = new A<string>("this is generic class");
    //            A<int> gen1 = new A<int>(101);
    //            A<char> genCh = new A<char>('S');

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //------------------------------------------------
    //GENERIC method--------------------
    class MyClass
    {
        static void Swap<T>(ref T num1, ref T num2)
        {
            T temp = default(T);
            temp = num2;
            num2 = num1;
            num1 = temp;
        }
        static void Main(string[] args)
        {
            int first = 4;
            int second = 5;
            Swap<int>(ref first, ref second);
            Console.WriteLine(first);
            Console.WriteLine(second);

            char ch1 = 'x';
            char ch2 = 'y';
            Swap<char>(ref ch1, ref ch2);
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);

            Console.ReadLine();
        }
    }
}



    

