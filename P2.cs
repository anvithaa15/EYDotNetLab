//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EYDotNetDay2
//{
//    class P2
//    {
//        static void Main(string[] args)
//        {
//            FileInfo f1 = new FileInfo();
//            Console.WriteLine(f1.FullName);
//            Console.WriteLine(f1.Name);
//            Console.WriteLine(f1.Length);
//            Console.WriteLine(f1.CreationTime);
//            Console.WriteLine(f1.LastAccessTime);
//            Console.WriteLine(f1.LastWriteTime);
//            Console.WriteLine(f1.Extension);

//            string path = @"C:\Users\labuser\Desktop";
            
//            if (File.Exists(student))
//            {
//                Console.WriteLine("File is present");

//                string[] lines = File.ReadAllLines(path);

//                foreach (var l in lines)
//                {
//                    Console.WriteLine(l);
//                }
//            }
//        }
//    }
//}

using System;
using System.IO; 

namespace EYPrograms
{
    class PROJECT 
    { 
        static void Main(string[] args) 
        {
            string path = "C:\\Users\\labuser\\Desktop\\Student.txt";
            if (File.Exists(path)) 
            {
                Console.WriteLine("File is present");
                string[] lines = File.ReadAllLines(path);
                foreach (var l in lines) 
                {
                    Console.WriteLine(l);
                }
            } 
            else Console.WriteLine("File does not exist");
            Console.ReadLine(); 
        }
    }
}