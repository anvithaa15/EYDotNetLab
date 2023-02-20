using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYDotNetDay2
{
    //class P1_20
    //{
    //    static void Main(string[] args)
    //    {
    //        const float pi = 3.142f;
    //        float pi1 = 3.142f;

    //        Console.WriteLine("pi :"+pi);
    //        Console.WriteLine("pi1 :"+pi1);

    //        P1_20 obj = new P1_20();
    //        obj.func1();

    //        func2();
    //        func3();

    //        Type t1 = typeof(P1_20); //gives the type of the obj.(class name here, class type)
    //        //Type t2 = typeof(pi1); error
    //        //Type t3 = typeof(func2); error

    //        Console.WriteLine(t1.Name);
    //        Console.WriteLine(t1.FullName);
    //        Console.ReadLine();
    //    }

    //    public void func1()
    //    {
    //        const float pi = 4.5678f;
    //        Console.WriteLine("pi value inside func1()"+pi);
    //    }

    //    static void func2()
    //    {
    //        Console.WriteLine("static void func2 is invoked");
    //    }

    //    public static void func3()
    //    {
    //        Console.WriteLine("static void func3 is invoked");
    //    }
    //}


    //====================================================
    //IS operator--------

    //class myclass1 { }
    //class myclass2 { }
    //class myclass
    //{

    //    static void Main(string[] args)
    //    {
    //        myclass1 myclass1 = new myclass1();
    //        myclass2 myclass2 = new myclass2();

    //        test(myclass1);
    //        test(myclass2);

    //        Console.ReadLine();

    //}
    //static void test(object obj)
    //{
    //    myclass1 obj1;
    //    myclass2 obj2;

    //    if (obj is myclass1)
    //    {
    //        Console.WriteLine("obj is myclass1");
    //        obj1 = (myclass1)obj;
    //    }
    //            else if (obj is myclass2)
    //            {
    //                Console.WriteLine("obj is myclass2");
    //                obj2 = (myclass2)obj;
    //            }
    //            else
    //            {
    //                Console.WriteLine("obj is neither class1 nor class2");
    //            }
    //        }
    //    }
    //}

    //=====================================================
    // AS operator--------------------------------------

    //    class Class1
    //    {
    //    }
    //    class Class2
    //    {
    //    }
    //    class IsTest
    //    {
    //        public static void Main()
    //        {
    //            object[] myObjects = new object[6];
    //            myObjects[0] = new Class1();
    //            myObjects[1] = new Class2();
    //            myObjects[2] = "string";
    //            myObjects[3] = 32;
    //            myObjects[4] = null;

    //            for (int i = 0; i < myObjects.Length; ++i)
    //            {
    //                string s = myObjects[i] as string;
    //                if (s != null)
    //         
    //                Console.Write("{0}:", i);
    //                    Console.WriteLine("'" + s + "'");
    //                else
    //                    Console.WriteLine("not a string");
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //=================================
    //Dynamic type--------------------------

    //class Myclass
    //{
    //    static void Main(string[] args)
    //    {
    //        dynamic var1 = 100;
    //        Console.WriteLine(var1);

    //        dynamic var2 = 2000.235f;
    //        Console.WriteLine(var2);

    //            dynamic var3 = "abcd";
    //            Console.WriteLine(var3);

    //            dynamic var4 = 'a';
    //            Console.WriteLine(var4);

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //Dynamic-2=======================================
    //------------------------------------
    //class Myclass
    //{
    //    dynamic d1 = 10;

    //    public int add(int a, int b)
    //    {
    //        return (a + b) * d1;
    //    }
    //}
    //class india
    //{
    //    static void Main(string[] args)
    //    {
    //        Myclass m1 = new Myclass();

    //        dynamic var1 = 10;
    //        dynamic var2 = 11;
    //        dynamic str = "Addition result is : ";

    //            Console.WriteLine(str + m1.add(var1, var2));

    //            var value = 15;
    //            // value="hello;"//error
    //            dynamic val = 15;
    //            val = "hello"; //no error
    //            Console.WriteLine(val);

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //=================================================
    //convert string to integer------------------------

    //class monday
    //{
    //    static void Main(string[] args)
    //    {
    //        string s1 = "20";
    //        Console.WriteLine("convert :" + Convert.ToInt32(s1));
    //        Console.WriteLine("parse :" + int.Parse(s1));

    //        string s2 = null;
    //        Console.WriteLine("convert :" + Convert.ToInt32(s2));
    //        // Console.WriteLine("parse : " + int.Parse(s2)); error

    //        string s3 = "abcd";
    //        //Console.WriteLine("convert :" + Convert.ToInt32(s3)); error
    //        // Console.WriteLine("parse : " + int.Parse(s3)); error

    //        bool b1 = true;
    //        Console.WriteLine("convert :" + Convert.ToInt32(b1));
    //        // Console.WriteLine("parse : " + int.Parse(b1)); design time error

    ////==================================================
    ////boxing and unboxing------------------------------

    //int a = 10;
    //object b = a;
    //Console.WriteLine(b);//boxing=value type-->object type

    //object c = 100;
    //Console.WriteLine(c);
    //int d = (int)c;
    //Console.WriteLine(d);//unboxing=object type-->value type

    //Console.ReadLine();
    //        }
    //    }
    //}

    //=====================================================
    //2 progs:----------------------------------------------
    class final
    {
        static void Main(string[] args)
        {
            dynamic age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("you can vote!");
            }
            else
                Console.WriteLine("oops! you cant vote yet.");

            Console.ReadLine();

            int a = 10;
            Console.WriteLine("convert :" + Convert.ToString(a));
            //Console.WriteLine("parse :" + int.Parse(a)); error. cant convert

            float b = 20.333f;
            Console.WriteLine("convert :" + Convert.ToString(b));
            //Console.WriteLine("parse :" + float.Parse(b)); cant convert float to string

            Console.ReadLine();

        }
    }
}


    
            



    



