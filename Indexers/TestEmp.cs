using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class TestEmp
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, 30000.23, "saljesh", "Data analaytics", "Analytics Department", "kirtipur");

            emp[2] = "Saljesh Maharjan";

            // second way
            emp["Eno"] = 20;

            Console.WriteLine("Eno: " + emp[0]);
            Console.WriteLine("Salary: " + emp[1]);
            Console.WriteLine("EName: " + emp[2]);
            Console.WriteLine("Job: " + emp[3]);
            Console.WriteLine("Department: " + emp[4]);
            Console.WriteLine("Location: " + emp[5]);

            Console.ReadLine();
        }
    }
}

