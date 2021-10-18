using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;

namespace Demo_Multitasking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing Multitaskin using Multithreading in C#");
            MyClass History = new MyClass();
            Console.WriteLine("Main Thread Started....!!");
            History.Display();


            ThreadStart th1 = History.Display;
            ThreadStart th2 = History.Read;
            Thread s1 = new Thread(th1);
            Thread s2 = new Thread(th2);
            s1.Start();
            s2.Start();

            Console.WriteLine("Main Thread ends here...");
            Console.ReadKey();
            
        }
    }
}
