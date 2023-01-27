using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    public class Home
    {
        //private string part = "mesi";
        public string party = "yes";
        protected string willbe = "wife";
        internal string inter = "hoalraw";
        protected internal string piss = "manihunxahola";

        string address;
        bool isBesideRoad;
        double price;
        int houseNumber;

        public Home(string address, bool isBesideRoad, double price, int houseNumber)
        {
            this.address = address;
            this.isBesideRoad = isBesideRoad;
            this.price = price;
            this.houseNumber = houseNumber;
        }

        public void DisplayDetails()
        {
            string roadTouched;

            if (isBesideRoad)
            {
                roadTouched = "Yes";
            }
            else
            {
                roadTouched = "No";
            }

            Console.WriteLine("House Number: " + this.houseNumber);
            Console.WriteLine("Location: " + this.address);
            Console.WriteLine("Road Touched: " + roadTouched);
            Console.WriteLine("Price: " + "Rs." + this.price);
            Console.WriteLine();
        }

    }


    public class Program
    {
        // 1. All access modifiers are accessible within same class
        private double bankBalance = 12556800.34;
        internal string wife = "Annika";
        protected internal void Secret()
        {
            Console.WriteLine("Bank Balance: " + bankBalance);
            Console.WriteLine("Wife: " + wife);
        }

        static void Main(string[] args)
        {
            Home saljeshHouse = new Home("GumbaArea, Kirtipur-2",false, 14500000.748,4968);

            saljeshHouse.DisplayDetails();

            // create obj of program to access the same class
            Program obj = new Program();
            obj.Secret();

            Console.ReadLine();
        }
    }
}
