using System;


namespace Enumeration
{
    enum Dates
    {
        sunday = 1, monday, tuesday, wednesday, thursday, friday, saturday
    }

    enum DiffernetIndex
    {
        sun = 1,
        mon = 45, 
        tue = 8, 
        wed = 89
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dates d = 0;
            //Dates d = 1; // not possible'

            Dates d2 = (Dates)1;

            Dates d3 = (Dates)2;

            Dates d4 = (Dates)3;

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            // another way
            Dates newway = Dates.monday;

            Console.WriteLine((int)newway);

            // sequence changed start = 1
            Dates newway2 = Dates.sunday;
            Console.WriteLine((int)newway2);


            // Accesssing second enum
            DiffernetIndex dd = DiffernetIndex.wed;
            Console.WriteLine((int)dd);
            Console.WriteLine();

            //get all data using foreach
            foreach (int i in Enum.GetValues(typeof(Dates)))
            {
                Console.WriteLine(i);
               
            }
            Console.WriteLine();
            foreach (string i in Enum.GetNames(typeof(Dates)))
            {
                Console.WriteLine(i);
            }
            

            Console.ReadLine();
        }
    }
}
