using System;

namespace MultipleInheritance
{
    interface Interface1
    {
        void Test();
        void Show();
    }

    interface Interface2 
    {
        void Test();
        void Show();
    }

    // interface is asking to implememnt not conumse so one test() means both are satisfied
    internal class Program: Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("I am solver for implemenetaion");
        }

        void Interface1.Show()
        {
            Console.WriteLine("I am for Interface 1");
        }

        void Interface2.Show()
        {
            Console.WriteLine("I am for Interface 2");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            // create reference of interface/ parent using chid
            Interface1 i = obj;
            i.Show();

            Interface2 i2 = obj;
            i2.Show();

            Console.ReadLine();
        }
    }
}
