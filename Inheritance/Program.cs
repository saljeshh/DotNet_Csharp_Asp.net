using System;

namespace Inheritance
{
    class Person
    {
        public string name;
        public float height;
        public bool isWhite;
        public bool isMarried;


        public Person(string name, float height, bool isWhite, bool isMarried)
        {
            this.name = name;
            this.height = height;
            this.isWhite = isWhite;
            this.isMarried = isMarried;
        }
    }

    class Teacher : Person
    {
        public string subject;
        public double salary;

        public Teacher(string subject, double salary) : base("Saljesh", 5.11f, true, false)
        {
            this.subject = subject;
            this.salary = salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Height: " + height + "ft.");
            Console.WriteLine("Is White: " + isWhite);
            Console.WriteLine("Is Married: " + isMarried);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("Salary: " + "Rs." + salary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Teacher saljesh = new Teacher("Data Analytics", 80000);
            saljesh.DisplayDetails();

            Console.ReadLine();
        }
    }
}
