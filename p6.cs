using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYDotNetDay2
{
    //structure====================================================

    //struct Book
    //{
    //    public int bookid;
    //    public string title;
    //    public int bookPrice;
    //}

    //struct mobile //inheritance is not supported
    //{
    //    public int mobileid;
    //    public string name;
    //    public int price;

    //    public void function1()
    //    {
    //        Console.WriteLine("welcome to structure");
    //    }
    //    public static void function2()
    //    {
    //        Console.WriteLine("static void function is invoked");
    //    }
    //}

    //class myClass
    //{
    //    static void Main(string[] args)
    //    {
    //        mobile m1 = new mobile();
    //        m1.function1();
    //        mobile.function2();

    //        Book b1 = new Book();
    //        b1.bookid = 101;
    //        b1.bookPrice = 1000;
    //        b1.title = "java book";

    //        Book b2 = new Book();
    //        b2.bookid = 102;
    //        b2.bookPrice = 950;
    //        b2.title = "Python book";

    //        Book b3 = new Book();
    //        b3.bookid = 115;
    //        b3.bookPrice = 850;
    //        b3.title = "c# book";

    //        Console.WriteLine("Book1 details: ");
    //        Console.WriteLine(b1.bookid);
    //        Console.WriteLine(b1.bookPrice);
    //        Console.WriteLine(b1.title);

    //        Console.WriteLine("Book2 details: ");
    //        Console.WriteLine(b2.bookid);
    //        Console.WriteLine(b2.bookPrice);
    //        Console.WriteLine(b2.title);


    //        Console.WriteLine("Book3 details: ");
    //        Console.WriteLine(b3.bookid);
    //        Console.WriteLine(b3.bookPrice);
    //        Console.WriteLine(b3.title);


    //        Console.ReadLine();


    //    }
    //}


    //constructor===================================================
    class india
    {
        public india() //default
        {
            Console.WriteLine("Default constructor is invoked");
        }
        public india(int a) //parameterized
        {
            Console.WriteLine("default constructor is invoked "+"  " +a);
        }
    }

    class constructor_demo
    {
        static void Main(string[] args)
        {
            india i1 = new india();
            india i2 = new india(5);

            Console.ReadLine();
        }
    }
}



