using System;


namespace MethodOverloading
{
    internal class Program
    {
        public void Test()
        {
            Console.WriteLine("Frist method");
        }
        /*
        public string Test()
        {
            return "Hello there wil be ambiguity between first and second return type doesnt matter as it is last not first";
        }
       */
        public void Test(int number)
        {
            Console.WriteLine(number);
        }

        public void Test(string name)
        {
            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Test();
            obj.Test(5);
            obj.Test("saljesh");

            Console.ReadLine();
        }
    }
}
