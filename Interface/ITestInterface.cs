using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // it only has abstract
    // default of members of 
    interface ITestInterface
    {

        // when declaring abstractmethod we dont need public and abstract
        // because by default it is public and abstract

        void Add(int a, int b);

    }

    // interface can inherit from another interface
    interface IChildInterface : ITestInterface
    {
        void Sum(int a, int b);
    }

    class Programs : IChildInterface
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add: " + (a + b));
        }
        public void Sum(int a, int b)
        {
            Console.WriteLine("sum: " + (a + b));
        }


        static void Main(string[] args)
        {
            Programs obj = new Programs();
            obj.Add(1, 2);
            obj.Sum(2, 4);

            Console.ReadLine();
        }
    }
}
