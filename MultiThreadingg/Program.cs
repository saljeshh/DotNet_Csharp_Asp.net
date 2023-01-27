using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

// 1. code without multithreadnig

namespace MultiThreadingg
{
    internal class Program
    {
        static void Run()
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Run2()
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Run);
            Thread t2 = new Thread(Run2);

            t1.Start();
            t2.Start();

            // after 5sec if the t1 doesnt finish main thread wont wait for t1 
            // t2 doesnt have parameter so main thread will wait until it finishes
            t2.Join(); t1.Join(5000);
            

            Console.ReadLine();
        }
    }
}
