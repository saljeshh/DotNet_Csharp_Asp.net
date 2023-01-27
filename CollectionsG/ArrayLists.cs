using System;
using System.Collections.Generic;
using System.Collections;

namespace CollectionsG
{
    internal class ArrayLists
    {
        static void Main(string[] args)
        {
            // ArrayList is non Generic class , it can store any type of data, no type safe
            ArrayList al = new ArrayList(10); // default size is 10

            al.Add(4);
            al.Add("Saljesh");
            al.Add(344.56);

            al.Insert(1, false);

            Console.WriteLine(al.Capacity);

            foreach(object data in al)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine("---------------");

            // Replacement of ArrayList is List , i.e Generic class, it is type safe <T>
            List <int> la = new List<int>();

            la.Add(4);
            la.Add(6);
            la.Add(9);

            la.Insert(2, 89);

            foreach(int data in la)
            {
                Console.WriteLine(data);    
            }

            try
            {
                la.Remove(4);

                la.RemoveAt(3);
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.WriteLine("-------------");

            foreach(int data in la)
            {
                Console.WriteLine(data);
            }


            Console.ReadLine();
        }
    }
}
