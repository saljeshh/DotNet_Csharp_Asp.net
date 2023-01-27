using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Circle
    {
        int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();

            c.X = 5;

            Console.WriteLine(c.X);


            Console.ReadLine();
        }
    }
}
