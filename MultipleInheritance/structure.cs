using System;

namespace Structure
{
    // structure in c can have memebeers only but in c# it can have most of class like memeber,properties, indexers, 

    struct Structure
    {
        int i;
        public void Test()
        {
            Console.WriteLine("Hello");
        }

        static void Main(string[] args)
        {
            Structure obj;
            obj.i = 5; // if not inatilized here it wont work
            obj.Test();

            Console.ReadLine();
        }
    }
}