using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void GetParts(double width, double height);
    public class Rectangle
    {
        public void GetArea(double width,double height)
        {
            Console.WriteLine(width * height);
        }

        public void GetPerimeter(double width,double height)
        {
            Console.WriteLine(2*(width + height));
        }

    }

    internal class MultiCastDeligate
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            //obj.GetPerimeter(10,10);
            //obj.GetArea(10,10);

            // instance of multicast deligate
            GetParts gp = new GetParts(obj.GetPerimeter);
            gp += obj.GetArea;

            // here for one invoke both functions are called that are linked to deligate
            gp.Invoke(20, 20);
            gp.Invoke(10, 20);

            Console.ReadLine();
        }
    }
}
