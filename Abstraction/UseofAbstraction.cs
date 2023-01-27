using System;

namespace Abstraction
{
    public abstract class Figure
    {
        public double width, height, radius;
        public const float pi = 3.14f;

        // abstraction comes now when we want to find area,
        // formula for all area of figures are differnt so to keep naming convention we keep abstraction of names
        public abstract double getArea();
    }

    public class Rectangle : Figure
    {
      
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double getArea()
        {
            return width * height;
        }
    }

    public class Circle : Figure
    {
       
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            return 2 * pi * radius;
        }
    }

    internal class UseofAbstraction
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(45, 56);
            Circle c = new Circle(10);

            Console.WriteLine("Area of Rectangle: "+ r.getArea());
            Console.WriteLine("Area of Circle: "+ c.getArea());

            Console.ReadLine();
        }
        
    }
}
