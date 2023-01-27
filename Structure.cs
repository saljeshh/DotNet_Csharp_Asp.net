using System;

namespace Structure
{
    // structure in c can have memebeers only but in c# it can have most of class like memeber,properties, indexers, 

    struct Structure
    {
        public void Test()
        {
            Console.WriteLine("Hello");
        }

        static void Main(string[] args)
        {
            Structure obj;

            obj.Test();

            Console.ReadLine();
        }
    }
}