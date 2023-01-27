using System;
using System.Collections.Generic;
using System.Collections;


namespace CollectionsG
{
    internal class HashMapDict
    {
        // Hash table is non generic class, it stores key value.

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "Saljesh Maharjan");
            ht.Add("Wife", "Annika Maharjan");
            ht.Add("Gender", "Male");
            ht.Add(4, 8);

            Console.WriteLine("Name".GetHashCode());


            foreach(object data in ht.Keys)
            {
                Console.WriteLine(data + " : " + ht[data]);
            }

            Console.WriteLine("---");

            foreach(object data in ht.Values)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("-----------");

            // REPLCEMENT OF hasthtable was DICTIONARY IN GENERICS CLASS
            Dictionary<string, object> dic = new Dictionary<string, object>();

            dic.Add("Name","Aney");
            dic.Add("Class", 13);
            dic.Add("Vechicle", "Ns200");

            foreach(object data in dic.Keys)
            {
                Console.WriteLine(data + " : " + dic[(string)data]);
            }


            Console.ReadLine();
            
        }
    }
}
