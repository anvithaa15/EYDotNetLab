//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EYDotNetDay2
//{
//    class p4
//    {
//        static void Main(string[] args)
//        {
//            doApp();
//        }
//        public static void doApp()
//        {
//            int x = 10;
//            if(x>=10)
//                Console.WriteLine("this is a conditional statement");

//            switch(x)
//            {
//                case 9:
//                    Console.WriteLine("this is switch statement resulting in 9");
//                    break;
//                case 10:
//                    Console.WriteLine("This is a switch statement resulting in 10");
//                    break;

//            }
//            while (x < 20)
//            {
//                x++;
//                Console.WriteLine("incrementing x in a while loop" + x);
//            }

//            do
//            {
//                x--;
//                Console.WriteLine("decrementing x in a do-while loop:" + x);
//            } while (x >= 10);

//            for(int i = 0; i <= x; i++)
//            {
//                Console.WriteLine("for loop to assign a value" + i);
//            }

//            string[] numbers = { "one", "two", "three", "four", "five" };
//            foreach(string s in numbers)
//            {
//                Console.WriteLine("foreach loop to iterate through an array :" + s);
//            }
//            Console.ReadLine();
//        }
//    }
//}
