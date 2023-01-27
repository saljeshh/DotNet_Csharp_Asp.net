using System;
using System.Collections.Generic;


namespace CollectionsG
{

    internal class UseOfGeneric
    {
        public bool Compare<T>(T item1, T item2)
        {
            if (item1.Equals(item2))
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            UseOfGeneric ob = new UseOfGeneric();


            Console.WriteLine(ob.Compare<int>(5, 4));

            Console.ReadLine();
        }
    }
}
