//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EYDotNetDay2
//{
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
    //class final
    //{
    //    static void Main(string[] args)
    //    {
    //        dynamic age = int.Parse(Console.ReadLine());
    //        if (age >= 18)
    //        {
    //            Console.WriteLine("you can vote!");
    //        }
    //        else
    //            Console.WriteLine("oops! you cant vote yet.");

    //        Console.ReadLine();

    //        int a = 10;
    //        Console.WriteLine("convert :" + Convert.ToString(a));
    //        //Console.WriteLine("parse :" + int.Parse(a)); error. cant convert

    //        float b = 20.333f;
    //        Console.WriteLine("convert :" + Convert.ToString(b));
    //        //Console.WriteLine("parse :" + float.Parse(b)); cant convert float to string

    //        Console.ReadLine();

    //    }
    //}
    //}
    //}

    //#############################################################################
    //Programs-feb21:===========================================================

    //    class calci
    //    {
    //        static void Main(string[] args)
    //        {
    //            string ch = "yes";
    //            while ((ch == "yes" || ch == "Y" || ch == "YES" || ch == "y") && (ch != "no" || ch != "NO" || ch != "n" || ch != "N"))
    //            {
    //                Console.WriteLine("ENTER FIRST NUMBER   : ");
    //                int a = int.Parse(Console.ReadLine());
    //                Console.WriteLine("ENTER SECOND NUMBER   : ");
    //                int b = int.Parse(Console.ReadLine());
    //                Console.WriteLine("ENTER OPERATOR   : ");
    //                char op = Convert.ToChar(Console.ReadLine());
    //                float res; switch (op)
    //                {
    //                    case '+':
    //                        res = a + b; ; Console.WriteLine("RESULT" + res);
    //                        break;
    //                    case '-':
    //                        res = a - b; ; Console.WriteLine("RESULT" + res);
    //                        break;
    //                    case '*':
    //                        res = a * b; ; Console.WriteLine("RESULT" + res);
    //                        break;
    //                    case '/':
    //                        res = a / b; ; Console.WriteLine("RESULT" + res);
    //                        break;
    //                    case '%':
    //                        res = a % b; ; Console.WriteLine("RESULT" + res);
    //                        break;
    //                    default:
    //                        Console.WriteLine("enter correct operator");
    //                        break;
    //                }
    //                Console.WriteLine("Do you want to continue");
    //                ch = Console.ReadLine();
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //===================================================================
    //and or demo-----------------------------------------------------

    //    class tuesday
    //    {
    //        static void Main(string[] args)
    //        {
    //            int x = 10, y = 20;
    //            if (x == 10 || y == 0)
    //                Console.WriteLine("welcome");
    //            else
    //                Console.WriteLine("bye");
    //            //            //float
    //            float a = 10.23f, b = 3.5f;
    //            if (a == 10 || b == 0)
    //                Console.WriteLine("India");
    //            else
    //                Console.WriteLine("UK");

    //            bool answer = true;
    //            bool result = false;

    //            if (answer == true && result == false)
    //                Console.WriteLine("input");
    //            else
    //                Console.WriteLine("output");

    //            //ternary operator ? :
    //            int result2 = (x > y) ? x : y;
    //            Console.WriteLine("ternary operator result is : "+result2);

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //===========================================================
    //    class Factorial
    //    {
    //        static void Main(string[] args)
    //        {
    //            int i, fact = 1; 
    //            Console.Write("Enter any Number: ");
    //            int number = int.Parse(Console.ReadLine());
    //            for (i = 1; i <= number; i++)
    //            {
    //                fact *= i;
    //            }
    //            Console.WriteLine("Factorial of the number is:"+fact);
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //==============================================================
    //palindrome

    //    class Palindrome
    //    {
    //        static void Main(string[] args)
    //        {
    //            int n, r, sum = 0, temp;
    //            Console.WriteLine("Enter Number: ");
    //            n = int.Parse(Console.ReadLine());
    //            temp = n;
    //            while (n > 0)
    //            {
    //                r = n % 10;
    //                sum = (sum * 10) + r;
    //                n = n / 10;
    //            }
    //            if (temp == sum)
    //                Console.WriteLine("Number is Palindrome.");
    //            else
    //                Console.WriteLine("Number is not Palindrome");
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //==============================================================
    //array-1--------------------------------------------------

    //    class array1
    //    {
    //        static void Main(string[] args)
    //        {
    //            int[] arr = new int[10];
    //            int[] arr1 = new int[5] { 2, 3, 4, 5, 6 };

    //            int[] arr2 = new int[5];
    //            arr2[0] = 10;
    //            arr2[1] = 11;
    //            arr2[2] = 5;
    //            arr2[3] = 3;
    //            arr2[4] = 8;

    //            foreach (int i in arr2)
    //            {
    //                Console.WriteLine(i);

    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //array-2--------------------------------------------------
    //class array2
    //{
    //    static void Main(string[] args)
    //    {
    //        int[,] arr = new int[2, 2];
    //        arr[0, 0] = 1;
    //        arr[0, 1] = 2;
    //        arr[1, 0] = 3;
    //        arr[1, 1] = 4;

    //        Console.WriteLine("2x2 matrix is :  ");

    //        for (int i = 0; i < 2; i++)
    //        {
    //            for (int j = 0; j < 2; j++)
    //            {
    //                Console.WriteLine(arr[i, j] + "    ");
    //                }
    //                Console.WriteLine();
    //            }
    //            Console.ReadLine();

    //            Console.WriteLine("enter row size: ");
    //            int rowsize = int.Parse(Console.ReadLine());

    //            Console.WriteLine("enter column size: ");
    //            int colsize = int.Parse(Console.ReadLine());

    //            int[,] arr3 = new int[rowsize, colsize];

    //            Console.WriteLine("array elements are : ");
    //            for(int i = 0; i < arr3.GetLength(0); i++)
    //            {
    //                for (int j = 0; j < arr3.GetLength(1); j++)
    //                {
    //                    arr3[i, j] = int.Parse(Console.ReadLine());
    //                }
    //                //Console.ReadLine();
    //            }
    //            Console.WriteLine("enter array elements in matrix format : ");
    //            for (int i = 0; i < arr3.GetLength(0); i++)
    //            {
    //                for (int j = 0; j < arr3.GetLength(1); j++)
    //                {
    //                    Console.WriteLine(arr[i,j]);
    //                }
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //array-3 incomp--------------------------------------------
    //class array3
    //{
    //    static void Main(string[] args)
    //    {
    //        int[, ,] arr = new int[3, 3];
    //        arr[0, 0] = 1;
    //        arr[0, 1] = 2;
    //        arr[1, 0] = 3;
    //        arr[1, 1] = 4;

    //        Console.WriteLine("2x2 matrix is :  ");

    //        for (int i = 0; i < 2; i++)
    //        {
    //            for (int j = 0; j < 2; j++)
    //            {
    //                Console.WriteLine(arr[i, j] + "    ");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}
    //}

    //------------------------------------------------------
    //array-4 addition--------------------

    //    class array4
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine("first matrix is: ");
    //            int[,] arr1 = new int[2, 2];
    //            int i, j;
    //            arr1[0, 0] = 2;
    //            arr1[0, 1] = 3;
    //            arr1[1, 0] = 7;
    //            arr1[1, 1] = 6;
    //            for (i = 0; i < 2; i++)
    //            {
    //                for (j = 0; j < 2; j++)
    //                {
    //                    Console.Write(arr1[i, j] + "  ");
    //                }
    //                Console.WriteLine();
    //            }
    //            Console.WriteLine("second matrix is: ");
    //            int[,] arr2 = new int[2, 2];
    //            arr2[0, 0] = 2;
    //            arr2[0, 1] = 4;
    //            arr2[1, 0] = 10;
    //            arr2[1, 1] = 7;
    //            for (i = 0; i < 2; i++)
    //            {
    //                for (j = 0; j < 2; j++)
    //                {
    //                    Console.Write(arr2[i, j] + "  ");
    //                }
    //                Console.WriteLine();
    //            }
    //            Console.WriteLine("Result is: ");
    //            for (i = 0; i < 2; i++)
    //            {
    //                for (j = 0; j < 2; j++)
    //                {
    //                    Console.Write(arr1[i, j] + arr2[i, j] + "  ");
    //                }
    //                Console.WriteLine();
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //================================
    //product

//    class addMul 
//    { 
//        static void Main(string[] args) 
//        { 
//            Console.WriteLine(" enter no .of rows"); 
//            int r1 = int.Parse(Console.ReadLine()); 
//            Console.WriteLine(" enter no .of columns"); 
//            int c1 = int.Parse(Console.ReadLine()); 
//            int[,] a = new int[r1, c1]; 
//            int[,] b = new int[r1, c1]; 
//            int[,] c = new int[r1, c1]; 
//            int i, j, k; 
//            Console.WriteLine("ENTER ELEMENTS OF FRST ARRAY"); 
//            for (i = 0; i < r1; i++) 
//            { 
//                for (j = 0; j < c1; j++) 
//                { 
//                    a[i, j] = int.Parse(Console.ReadLine()); 
//                } 
//            } 
//            Console.WriteLine("ENTER ELEMENTS OF SECOND ARRAY"); 
//            for (i = 0; i < r1; i++) 
//            { 
//                for (j = 0; j < c1; j++) 
//                { 
//                    b[i, j] = int.Parse(Console.ReadLine()); 
//                    c[i, j] = 0; 
//                } 
//            } 
//            Console.WriteLine("SUM OF TWO ARRAYS"); 
//            for (i = 0; i < r1; i++) 
//            { 
//                for (j = 0; j < c1; j++) 
//                { 
//                    Console.Write(a[i, j] + b[i, j] + " "); 
//                } 
//                Console.WriteLine(); 
//            } 
//            Console.WriteLine("PRODUCT OF TWO ARRAYS"); 
//            for (i = 0; i < r1; i++) 
//            { 
//                for (j = 0; j < c1; j++) 
//                { 
//                    for (k = 0; k < c1; k++) 
//                    { 
//                        c[i, j] += a[i, k] * b[k, j]; 
//                    } 
//                    Console.Write(c[i, j] + " "); 
//                } Console.WriteLine(); 
//            } 
//            Console.ReadLine(); 
//        } 
//    }
//}












