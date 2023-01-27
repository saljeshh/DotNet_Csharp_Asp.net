using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Program
    {

        // Implicit Constructor
        int i;
        bool b;

        string name;
        string address;
        string gender;

        // Explicit Constructor
        public Program(int value, string name, string address, string gender)
        {
            this.i = value;
            this.name = name;
            this.address = address;
            this.gender = gender;
        }

        // Copy Constructor
        public Program(Program param)
        {
            i = param.i;
            name = param.name;
            address = param.address;    
            gender = param.gender; 
        }

        public void Display()
        {
            Console.WriteLine($"I'm a Sigma {gender},  My name is {name} and I am from {address}");

        }

        // static Constructor
        static Program()
        {
            Console.WriteLine("I'm called as soon as main runs");
        }

        static void Main(string[] args)
        {
            Program originalPara = new Program(5,"saljesh", "kirtipur", "Male");

            // this was implicit constructor by defalut of bool is false;
            Console.WriteLine(originalPara.b);

            // explicit constructor - -we assigned 5 inside parameter 
            Console.WriteLine($"My name is {originalPara.name} and I am from {originalPara.address} a Sigma {originalPara.gender}");

            // copy constructor 
            Program copy = new Program(originalPara);
            copy.Display();

            Console.ReadLine();

        }
    }
}
