//============================OOPS Concept===============================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYDotNetDay2
{
    //class Vehicle
    //{
    //    public void enginemade()
    //    {
    //        Console.WriteLine("engine made details will be displayed...");
    //    }
    //    public void quality()
    //    {
    //        Console.WriteLine("vehicle quality info is displayed...");
    //    }
    //}

    //class scooter
    //{
    //    public void color()
    //    {
    //        Console.WriteLine("color of the scooter will be displayed...");
    //    }
    //}

    //class mainclass
    //{
    //    static void Main(string[] args)
    //    {
    //        Vehicle obj = new Vehicle();
    //        obj.enginemade();
    //        obj.quality();

    //        scooter ob = new scooter();
    //        ob.color();

    //        Console.ReadLine();
    //    }
    //}
    //}

    //---------------access specifiers-------------------

    //class india
    //{
    //    public int id;
    //    public string name;
    //    public void display()
    //        {
    //            Console.WriteLine("Hello and welcome to India");
    //        }        
    //}

    //class UK
    //{
    //    private int id;
    //    private string name;

    //}

    //class US
    //{
    //    protected int id;
    //    protected string name;
    //}
    //class myclass
    //{
    //    static void Main(string[] args)
    //    {
    //        india i = new india();
    //        i.id = 15;// only static func can access static variable.
    //        i.name = "Anvitha";
    //        i.display();
    //        Console.WriteLine("id value is "+i.id);
    //        Console.WriteLine("name is "+i.name);


    //            UK u = new UK();   //we cant access private and protected directly.
    //            US a = new US();   //must be inherited.                           


    //        Console.ReadLine();
    //    }
    //    }
    //}

    //----------single level and multilevel inheritence-----------------
    //    class vehicle
    //    {
    //        public void Vehiclecolor()
    //        {
    //            Console.WriteLine("you can customize the vehicle color");
    //        }
    //        public void Vehiclemodel()
    //        {
    //            Console.WriteLine("We will give you model number");
    //        }
    //    }
    //    class car : vehicle  //inheriting parent class through :
    //    {
    //        public void carbuild()
    //        {
    //            Console.WriteLine("your car is amazing");
    //        }

    //    }
    //    class kia : car   //multilevel inheritence
    //    {
    //        public void func()
    //        {
    //            Console.WriteLine("kia is good");
    //        }
    //    }
    //    class bus : car  //Hierarchial inheritence
    //    {
    //        public void func2()
    //        {
    //            Console.WriteLine("bus is not a car lol");
    //        }
    //    }
    //    class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            car c = new car();
    //            c.Vehiclecolor();
    //            c.Vehiclemodel();
    //            c.carbuild();

    //            kia b = new kia(); //multilevel inheritence
    //            b.func();

    //            bus d = new bus();
    //            d.func2();

    //            d.carbuild();
    //            d.Vehiclecolor();

    //            //vehicle v = new vehicle();
    //            //v.Vehiclecolor();
    //            //v.Vehiclemodel();

    //            Console.ReadLine();
    //        }
    //    }
    //}

    // --------------------------------------inheritance ex-
    //    class india
    //    {
    //        protected int indiaid = 10;
    //        public void func1()
    //        {
    //            Console.WriteLine("func1 from india invoked and id is :"+indiaid);
    //        }
    //    }
    //    class bangalore : india
    //    {
    //        private int blrid = 15;
    //        public void func2()
    //        {
    //            Console.WriteLine("func2 from bangalore is invoked and id is :" + blrid);
    //        }

    //    }
    //    class mysore : bangalore
    //    {
    //        public int mysid = 5;
    //        public void func3()
    //        {
    //            Console.WriteLine("func3 from mysore invoked and id is :" + mysid);
    //        }
    //    }
    //    class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            india i = new india();
    //            i.func1();

    //            bangalore b = new bangalore();
    //            b.func1();
    //            b.func2();

    //            mysore m = new mysore();
    //            m.func1();
    //            m.func2();
    //            m.func3();

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //-------------------Abstraction------------------------------

    //------------------polymorphism-------------------------
    //----------------1) function overloading-------------------
    //    class calc
    //    {
    //        public void add(int a, int b)
    //        {
    //            Console.WriteLine("addition result is-2 numbers :" + (a + b));
    //        }
    //        public void add(int a, int b, int c)
    //        {
    //            Console.WriteLine("addition result is-3 numbers :" + (a + b + c));
    //        }
    //        public int add(int a, int b, int c, int d)
    //        {
    //            //Console.WriteLine("addition result is-4 numbers :" + (a + b + c+d));
    //            return a + b + c + d;
    //        }

    //    }
    //    class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            calc obj = new calc();
    //            //Console.WriteLine("result is :"+obj.add(2,3));
    //            obj.add(2, 3);
    //            obj.add(6, 3, 6);
    //            Console.WriteLine(obj.add(3,6,4,9));
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //-----------------operator overloading-----------------------
    //    class complex
    //    {
    //        private int x;
    //        private int y;

    //        public complex() //default
    //        {

    //        }
    //        public complex(int i, int j)
    //        {
    //            x = i;
    //            y = j;
    //        }
    //        public void showxy()
    //        {
    //            Console.WriteLine("{0} {1}", x, y);
    //        }
    //        public static complex operator -(complex c)
    //        {
    //            complex temp = new complex();
    //            temp.x = -c.x;
    //            temp.y = -c.y;
    //            return temp;
    //        }
    //    }
    //    class Myclient
    //    {
    //        public static void Main(string[] args)
    //        {
    //            complex c1 = new complex(10, 20);
    //            c1.showxy();//displays 10 20

    //            complex c2 = new complex();
    //            c2.showxy();//displays 0 0

    //            c2 = -c1;
    //            c2.showxy();//displays -10 -20

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //---------------------function overriding--------------------------
    class myclass
    {
        public virtual void func1()
        {
            Console.WriteLine("function 1---myclass");
        }

    }
    class india : myclass
    {
        public override void func1()
        {
            Console.WriteLine("function 1---india");
            //base.func1();
        }
    }
    class prog
    {
        static void Main(string[] args)
        {
            //myclass m1 = new myclass();
            //m1.func1();
            india i = new india();
            i.func1();             //india's func1 function will be executed over myclass func

            Console.ReadLine();
        }
    }
}

