//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EYDotNetDay2
//{
    //=========================FILE HANDLING================================

    //    class P24
    //    {
    //        static void Main(string[] args)
    //        {
    //            FileInfo f1 = new FileInfo("C:\\Users\\labuser\\Desktop");
    //            Console.WriteLine("full name is: "+f1.FullName);
    //            Console.WriteLine("file name is: "+f1.Name);
    //            Console.WriteLine("file extension is :"+f1.Extension);
    //            Console.WriteLine("file last acces time is :"+f1.LastAccessTime);
    //            Console.WriteLine("file last write time is :"+f1.LastWriteTime);
    //            Console.WriteLine("file creation time is :"+f1.CreationTime);
    //            //Console.WriteLine("file length is :"+f1.Length);

    //            Console.WriteLine();

    //            DriveInfo d1 = new DriveInfo("C:\\");
    //            Console.WriteLine("drive name is :"+d1.Name);
    //            Console.WriteLine("drive total size is :"+d1.TotalSize);
    //            Console.WriteLine("drive volume label is :"+d1.VolumeLabel);
    //            Console.WriteLine("drive available free space is :"+d1.AvailableFreeSpace);
    //            Console.WriteLine("drive root directory :"+d1.RootDirectory);

    //            Console.WriteLine();

    //            DirectoryInfo d2 = new DirectoryInfo("c:\\Program Files");
    //            Console.WriteLine("directory fullname is :"+d2.FullName);
    //            Console.WriteLine("directory name is :"+d2.Name);
    //            Console.WriteLine("directory parent is :"+d2.Parent);
    //            Console.WriteLine("directory creation time is :"+d2.CreationTime);
    //            Console.WriteLine("directory last acces time is :"+d2.LastAccessTime);
    //            Console.WriteLine("directory last write time is :"+d2.LastWriteTime);

    //            Console.WriteLine();

    //            Directory.CreateDirectory("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2\\demo1");
    //            Directory.CreateDirectory("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2\\demo2");
    //            Directory.CreateDirectory("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2\\demo3");

    //            Directory.Delete("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2\\demo3");

    //            Console.WriteLine("directories in repos folder :");
    //            foreach (var item in Directory.GetDirectories("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2"))
    //            {
    //                Console.WriteLine(item);
    //            }
    //            Console.WriteLine();
    //            Console.WriteLine();

    //            Console.WriteLine("files in repos folder :");
    //            foreach (var item in Directory.GetFiles("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2"))
    //            {
    //                Console.WriteLine(item);
    //            }

    //            Console.ReadLine();

    //        }
    //    }
    //}

    //-----------------------------------------------------------

    //class MyClass
    //{
    //    static void Main(string[] args)
    //    {
    //            try
    //            {

    //                using (StreamReader rdr = new StreamReader("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2\\student.txt"))
    //                {
    //                    string line;
    //                    while ((line = rdr.ReadLine()) != null)
    //                    {
    //                        Console.WriteLine(line);
    //                    }
    //                }
    //            }
    //            catch(Exception ex)
    //            {
    //                Console.WriteLine("file not found...!"+ex.Message);
    //            }

    //to write into file---
    //1st way--------------

    //string[] names = new string[] { "anvitha", "bhoomika", "anusha" };
    //using(StreamWriter sw=new StreamWriter("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2\\student.txt"))
    //{
    //    foreach(string n in names)
    //    {
    //        sw.WriteLine(n);
    //    }
    //}
    //Console.WriteLine("file executed succesfully");

    //to write into file---
    //2nd way--------------

    //string line1 = " ";
    //Console.WriteLine("enter input: ");
    //line1 = Console.ReadLine();

    //using (StreamWriter sw = new StreamWriter("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2\\student.txt"))
    //{
    //    sw.WriteLine(line1); //override
    //}
    //File f1 = new File("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2\\student.txt", FileMode.OpenOrCreate, FileAccess.Read);

    //to delete the file-----
    //File.Delete("file path");

    //to copy file to another loc----
    //File.Copy("sourse loc","dest loc");

    //            string line2 = "This is just a text file" +
    //                           "     this is the second line" +
    //                           "     this is 3rd line...";
    //            File.AppendAllText("C:\\Users\\labuser\\source\\repos\\EYDotNetDay2\\student.txt", line2);

    //            Console.WriteLine("file executed succesfully");

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //-------------------------------------
    //enumeration demo-----------

    //    class EnumClass
    //    {
    //        enum days
    //        {
    //            mon,
    //            tue,
    //            wed,
    //            thus,
    //            fri,
    //            sat,
    //            sun
    //        }

    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine(days.mon);
    //            Console.WriteLine(days.fri);

    //            int a = (int)(days.mon);
    //            Console.WriteLine(a);

    //            int b = (int)(days.wed);
    //            Console.WriteLine(b);

    //            Console.ReadLine();
    //        }
    //    }
    //}

    //---nested try catch example----
    //    class nest
    //    {

    //        static void Main(string[] args)
    //        {
    //            var num = 0;

    //            try
    //            {
    //                try
    //                {
    //                    var result = 100 / num;
    //                }
    //                catch
    //                {
    //                    Console.WriteLine("one catch statement");
    //                }
    //            }
    //            catch
    //            {
    //                Console.WriteLine("another catch statement executed");
    //            }
    //            Console.ReadLine();
    //        }
    //    }
    //}

    //==========================================
    //Delegates-----------------------------------------
    //-----single cast---------------

    //    class Del
    //    {
    //       public delegate void mydelegate(); //declare the delegate

    //        static void Main(string[] args)
    //        {
    //            //Del m1 = new Del(); we can create an obj regularly and use delegate by-below--

    //            mydelegate m1 = new mydelegate(add);//(m1.add) can be used if func is public
    //            m1();

    //            mydelegate m2 = new mydelegate(multiply);//(m2.multiply can be used if func is public
    //            m2();

    //            Console.ReadLine();
    //        }

    //        static void add()
    //        {
    //            int a = 10, b = 20;
    //            Console.WriteLine("Addition result is : " + (a + b));
    //        }
    //        static void multiply()
    //        {
    //            int a = 10, b = 20;
    //            Console.WriteLine("Multiplication result is : " + (a * b));
    //        }
    //    }
    //}

    //----------multi cast--by using += which adds the pointer-------------------------

    //    class Del
    //    {
    //        public delegate void mydelegate(); //declare the delegate

    //        static void Main(string[] args)
    //        {
    //            Del m1 = new Del(); //we can create an obj regularly and use delegate by-below--

    //            mydelegate m2 = new mydelegate(m1.add);//(m1.add) can be used if func is public
    //            m2 += m1.subtract;
    //            m2 -= m1.multiply;//multiply func is not executed(-)
    //            m2 += m1.divide;
    //            m2();

    //            //mydelegate m2 = new mydelegate(multiply);//(m2.multiply can be used if func is public
    //            //m2();-no need in this prog

    //            Console.ReadLine();
    //        }

    //        public void add()
    //        {
    //            int a = 10, b = 20;
    //            Console.WriteLine("Addition result is : " + (a + b));
    //        }
    //        public void multiply()
    //        {
    //            int a = 10, b = 20;
    //            Console.WriteLine("Multiplication result is : " + (a * b));
    //        }
    //        public void subtract()
    //        {
    //            int a = 10, b = 20;
    //            Console.WriteLine("Subtraction result is : " + (a - b));
    //        }
    //        public void divide()
    //        {
    //            int a = 10, b = 20;
    //            Console.WriteLine("Division result is : " + (a / b));
    //        }
    //    }
    //}

    //----------multicast with parameters------------

    //    class Del
    //    {
    //        public delegate void mydelegate(int x, int y); //declare the delegate

    //        static void Main(string[] args)
    //        {
    //            Del m1 = new Del(); //we can create an obj regularly and use delegate by-below--

    //            mydelegate m2 = new mydelegate(m1.add);//(m1.add) can be used if func is public
    //            m2 += m1.subtract;
    //            m2 += m1.multiply;//multiply func is not executed(-)
    //            m2 += m1.divide;

    //            m2(12,2);

    //            //mydelegate m2 = new mydelegate(multiply);//(m2.multiply can be used if func is public
    //            //m2();-no need in this prog

    //            Console.ReadLine();
    //        }

    //        public void add(int a, int b)
    //        {

    //            Console.WriteLine("Addition result is : " + (a + b));
    //        }
    //        public void multiply(int a, int b)
    //        {

    //            Console.WriteLine("Multiplication result is : " + (a * b));
    //        }
    //        public void subtract(int a, int b)
    //        {

    //            Console.WriteLine("Subtraction result is : " + (a - b));
    //        }
    //        public void divide(int a, int b)
    //        {

    //            Console.WriteLine("Division result is : " + (a / b));
    //        }
    //    }
    //}

    ////------multicast with return type-------

    //    class Del
    //    {
    //    public delegate int mydelegate(int x, int y); //declare the delegate

    //    static void Main(string[] args)
    //    {
    //        Del m1 = new Del(); //we can create an obj regularly and use delegate by-below--

    //            Console.WriteLine("enter first number :");
    //            int num1 = int.Parse(Console.ReadLine());

    //            Console.WriteLine("enter second number :");
    //            int num2 = int.Parse(Console.ReadLine());

    //            mydelegate m2 = new mydelegate(m1.add);//(m1.add) can be used if func is public
    //            Console.WriteLine("addition result is :"+m2(num1,num2));

    //            m2 += m1.subtract;
    //            Console.WriteLine("subtraction result is :"+m2(num1,num2));

    //            m2 += m1.multiply;//multiply func is not executed(-)
    //            Console.WriteLine("multiplication result is :" + m2(num1, num2));

    //            m2 += m1.divide;
    //            Console.WriteLine("division result is :" + m2(num1, num2));

    //            //Console.WriteLine("Result is : "+ m2(12, 2)); gives only one result

    //        //mydelegate m2 = new mydelegate(multiply);//(m2.multiply can be used if func is public
    //        //m2();-no need in this prog

    //        Console.ReadLine();
    //    }

    //    public int add(int a, int b)
    //    {

    //        return (a + b);
    //    }
    //    public int multiply(int a, int b)
    //    {

    //        return (a * b);
    //    }
    //    public int subtract(int a, int b)
    //    {

    //        return (a - b);
    //    }
    //    public int divide(int a, int b)
    //    {

    //        return (a / b);
    //    }
    //    }
    //}
//}
