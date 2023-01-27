using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    // delegaet is a type so all the types are defined in namespace
  
    Delegtate is a type safe function pointer.
    = A delegate holds the reference of a method and then calls the method for execution.
    = To call a method by using a delegate we have 3 steps

    step 1: Define a delegate
    [<modifier>] delegate void/type <name>([<paramter list>])

    step 2: create instance of deligate

    step 3: Now call the deligate using required params value
 */

namespace Delegates
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegae(string s);
    internal class Program
    {
        // without deligate we can call methods in these two ways
        public void AddNums(int a, int b)
        {
            Console.WriteLine("Sum = " + (a + b));
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.AddNums(3, 5);

            // now we are going to call addnum function using deleage
            AddDelegate ad = new AddDelegate(obj.AddNums);
            SayDelegae sd = new SayDelegae(SayHello);


            // call the deligate using required aprams
            ad(6, 7);
            // we can even call like using invoke()
            ad.Invoke(9, 8);

            string prints = sd("Annika"); 
            Console.WriteLine(prints);

            Console.WriteLine(SayHello("Saljesh"));

            Console.ReadLine();
        }
    }
}
