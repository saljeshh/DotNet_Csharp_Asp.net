using System;


namespace Abstraction
{
    // abstraction need abstract class and methods, abstract methods must be overridden only then non abstract methods of abstract can be consumed.
    
    public abstract class Parent
    {
        // abstract methods doenst have body
        public abstract void Test();
        public void Test2()
        {
            Console.WriteLine("I am non abstract method of abstract class");
        }
    }

    internal class Program : Parent
    {
        public override void Test()
        {
            Console.WriteLine("I was abstract method first now i am overrideen");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Test();


            // we can only access non abstarct of abstract class once the abstract methd is overridden 
            obj.Test2();

            Console.ReadLine();
        }
    }
}
