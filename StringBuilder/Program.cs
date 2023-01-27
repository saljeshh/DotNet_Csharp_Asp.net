using System;
using System.Text;
using System.Linq;


namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // string are immutable
            string str = "Hello";
            str = str + " World";

            // using string builder
            StringBuilder st = new StringBuilder("Welcome");
            st.Append("Hello world");

            Console.WriteLine(st);

            Console.WriteLine(str);
            Console.ReadLine();     
        }
    }
}
