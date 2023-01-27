using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                int y = int.Parse(Console.ReadLine());

                int z = x / y;
                Console.WriteLine("The result is: " + z);
            }catch(DivideByZeroException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // this will handle expect above two anyone
            catch (Exception last)
            {
                Console.WriteLine(last.Message);
            }

            Console.WriteLine("End of program");

            Console.ReadLine();
        }
    }
}
