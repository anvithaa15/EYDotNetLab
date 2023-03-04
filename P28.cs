//===========================interfaces===========================
//-------set of functions,supports multiple inheritance---------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace EYDotNetDay2
//{
    //    interface imyinterface1    
    //    {
    //        void add();
    //        void remove();

    //    }
    //    interface imyinterface2
    //    {
    //        void clear();
    //    }
    //    class myclass:imyinterface1,imyinterface2 //implicit interface
    //    {
    //        public void add()
    //        {
    //            Console.WriteLine("add function");
    //        }
    //        public void  remove()
    //        {
    //            Console.WriteLine("remove function");
    //        }
    //        public void clear()
    //        {
    //            Console.WriteLine("clear function");
    //        }
    //    }
    //    class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            myclass m = new myclass();
    //            m.add();
    //            m.remove();
    //            m.clear();

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //--------------------------------------------------
    //    interface imyinterface1
    //    {
    //        void add();
    //        void remove();

    //    }
    //    interface imyinterface2
    //    {
    //        void clear();
    //    }
    //    class myclass : imyinterface1, imyinterface2 //explicit interface
    //    {
    //         void imyinterface1.add()
    //        {
    //            Console.WriteLine("add function invoked");
    //        }
    //        void imyinterface1.remove()
    //        {
    //            Console.WriteLine("remove function invoked");
    //        }
    //         void imyinterface2.clear()
    //        {
    //            Console.WriteLine("clear function invoked");
    //        }
    //    }
    //    class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            // myclass a = new myclass();//cannot invoke interfaces
    //            //imyinterface1 m=new imyinterface1 -->error, we cant do this

    //            imyinterface1 a = new myclass();
    //            a.add();
    //            a.remove();
    //            imyinterface2 m = new myclass();
    //            m.clear();                       //so,instantiate using interface with
    //                                            //class name, for each interfaces to call methods.

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //-----------------------sealed keyword------------------------------------
    //sealed class A //stops inheritance, like final in java
    //{
    //    public void func1()
    //    {
    //        Console.WriteLine("you cant inherit me");
    //    }
    //}
    ////class B : A //gives error as we cant inherit from class A
    ////{

    ////}
    //class myclass
    //{
    //    static void Main(string[] args)
    //    {
    //        A obj = new A();
    //        obj.func1();
    //            Console.ReadLine();
    //    }
    //}
    //}

    //-----------------constructors again (copy,private,static)-----------------------
    //    class myclass
    //    {
    //        int k = 10;
    //        int j = 20;
    //        public myclass()
    //        {
    //            Console.WriteLine("default constructor is invoked");
    //        }
    //        public myclass(int a, int b)
    //        {
    //            k = a;
    //            j = b;
    //        }
    //        public void display()
    //        {
    //            Console.WriteLine("k value is :" + k);
    //            Console.WriteLine("j value is :" + j);
    //        }

    //    }
    //    class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            myclass m1 = new myclass();//default constructor
    //            m1.display();

    //            myclass m2 = new myclass(100, 200);//parameterized constructor
    //            m2.display();

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //------------------------copy constructor----------------
    //    class employee
    //    {
    //        private string name;
    //        private int age;

    //        public employee(employee emp)  //declaring copy constructor
    //        {
    //            name = emp.name;
    //            age = emp.age;
    //        }
    //        public employee(string name, int age) //instance constructor
    //        {
    //            this.name = name;
    //            this.age = age;

    //        }
    //        public void display()
    //        {
    //            Console.WriteLine("name is: " + name);
    //            Console.WriteLine("age is: " + age);
    //        }
    //    }
    //    class empdetail
    //    {
    //        static void Main(string[] args)
    //        {
    //            employee emp1 = new employee("anvitha", 23); //create a new employee object.
    //            emp1.display();
    //            employee emp2 = new employee(emp1); //here,emp1 details copied to emp2.
    //            emp2.display();

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //-----------------------private constructor---------------
    //    class counter
    //    {
    //        private counter() //private constructor declaration
    //        {
    //        }
    //        public static int currentview;
    //        public static int visitedCount()
    //        {
    //            return ++currentview;
    //        }
    //    }
    //    class viewCountDetails
    //    {
    //        static void Main(string[] args)
    //        {
    //            //counter c = new counter(); //gives error. we cant create objects here
    //            counter.currentview = 500;
    //            counter.visitedCount();
    //            Console.WriteLine("view count is: {0}", counter.currentview);
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //-------------------static constructor-------------------
    //    class account
    //    {
    //        public int id;
    //        public String name;
    //        public static float rateofInterest;//static value

    //        public account(int id, String name)//parameterized constructor
    //        {
    //            this.id = id;
    //            this.name = name;//cant initialize static value like here
    //        }

    //        static account()//create static constructor and initialize the value here.
    //        {
    //            rateofInterest = 9.5f;
    //        }
    //        public void display()
    //        {
    //            Console.WriteLine(id + "  " + name + "   " + rateofInterest);
    //        }
    //    }
    //    class test
    //    {
    //        public static void Main(string[] agrs)
    //        {
    //            account a1 = new account(101, "anvitha");
    //            account a2 = new account(102, "bhoomika");

    //            a1.display();
    //            a2.display();

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //====================abstract class========================
    //    abstract class myclass1
    //    {
    //        public abstract void func1();
    //        public abstract void func2();
    //        public void func3()
    //        {
    //            Console.WriteLine("welcome to abstract class");
    //        }
    //    }
    //    class US : myclass1
    //    {
    //        public override void func1()
    //        {
    //            Console.WriteLine("us class--func1()");
    //        }
    //        public override void func2()
    //        {
    //            Console.WriteLine("us class--func2()");
    //        }
    //    }
    //    class india
    //    {
    //        static void Main(string[] args)
    //        {
    //           // myclass1 o = new myclass1(); cant create obj for abstract class

    //            US obj = new US();
    //            obj.func1();
    //            obj.func2();
    //            obj.func3();

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //---------------------------upcasting--------------------

    //    class shape
    //    {
    //        public int mx;
    //        public int my;
    //        public shape(int x, int y)
    //        {
    //            mx = x;
    //            my = y;
    //        }
    //        public virtual void draw()
    //        {
    //            Console.WriteLine($"Drawing shape at : {mx} , {my}");
    //        }
    //    }
    //    class square : shape
    //    {
    //        public square(int x, int y) : base(x, y)
    //        { }
    //        public override void draw()
    //        {
    //            Console.WriteLine($"Drawing square at : {mx} , {my}");
    //        }
    //    }
    //    class circle : shape
    //    {
    //        public circle(int x, int y) : base(x, y)
    //        { }
    //        public override void draw()
    //        {
    //            Console.WriteLine($"Drawing circle at : {mx} , {my}");
    //        }
    //    }
    //    class shapeprgm
    //    {
    //        static void Main(string[] args)
    //        {
    //            shape sh = new shape(100, 100);
    //            sh.draw(); square sh1 = new square(200, 200);
    //            sh1.draw(); circle sh2 = new circle(300, 300);
    //            sh2.draw();

    //            shape[] shape = new shape[3];
    //            shape[0] = new shape(100, 100);
    //            shape[1] = new square(200, 200);
    //            shape[2] = new circle(300, 300); 

    //            foreach (shape obj1 in shape)
    //            {
    //                obj1.draw();
    //            }
    //            Console.ReadKey();
    //        }
    //    }
    //}

    //=========================Property==========================
    //-----------------automatic property--------
    //    class employee
    //    {
    //        public int id { get; set; }
    //        public string name { get; set; }
    //        public int salary { get; set; }
    //    }
    //    class Class
    //    {
    //        static void Main(string[] args)
    //        {
    //            employee emp = new employee();
    //            emp.id = 101;
    //            emp.name = "anvitha";
    //            emp.salary = 60000;

    //            Console.WriteLine("employee id is" +emp.id);
    //            Console.WriteLine("employee name is" + emp.name);
    //            Console.WriteLine("employee salary is" + emp.salary);

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //-----------------------
    //    class myclass
    //    {
    //        private int id;
    //        public int ID
    //        {
    //            get
    //            {
    //                return id;
    //            }
    //            set
    //            {
    //                id = value;
    //            }
    //        }
    //    }

    //    class Client
    //    {
    //        public static void Main(string[] args)
    //        {
    //            myclass mc = new myclass();

    //            mc.ID = 10;
    //            int xVal = mc.ID;

    //            Console.WriteLine(xVal);

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //---------------------------

    //class myclass
    //{
    //    int id;
    //    string na;
    //    int sal;

    //    //private int id;
    //    public int ID
    //    {
    //        get          //accessors
    //        {
    //            return id;
    //        }
    //        set
    //        {
    //            id = value;
    //        }
    //    }
    //    public string name
    //        {
    //            get
    //            {
    //                return na;
    //            }
    //            set
    //            {
    //                na = value;
    //            }
    //        }
    //    public int salary
    //        {
    //            get
    //            {
    //                return sal;
    //            }
    //            set
    //            {
    //                sal = value;
    //            }
    //        }
    //}

    //class Client
    //{
    //    static void Main(string[] args)
    //    {
    //            myclass e1 = new myclass();
    //            e1.ID = 100;
    //            e1.name = "anvitha";
    //            e1.salary = 80000;

    //            myclass e2 = new myclass();
    //            e2.ID = 101;
    //            e2.name = "bhoomika";
    //            e2.salary = 70000;

    //            myclass e3 = new myclass();
    //            e3.ID = 102;
    //            e3.name = "anusha";
    //            e3.salary = 60000;

    //            Console.WriteLine("employee 1 details are:");
    //            Console.WriteLine("employee name is :"+e1.name);
    //            Console.WriteLine("employee id is :" + e1.ID);
    //            Console.WriteLine("employee salary is :" + e1.salary);

    //            Console.WriteLine("employee 2 details are:");
    //            Console.WriteLine("employee name is :" + e2.name);
    //            Console.WriteLine("employee id is :" + e2.ID);
    //            Console.WriteLine("employee salary is :" + e2.salary);

    //            Console.WriteLine("employee 3 details are:");
    //            Console.WriteLine("employee name is :" + e3.name);
    //            Console.WriteLine("employee id is :" + e3.ID);
    //            Console.WriteLine("employee salary is :" + e3.salary);      

    //            Console.ReadLine();
    //    }
    //}
    //}

    //--------------------------read only and write only----

//}