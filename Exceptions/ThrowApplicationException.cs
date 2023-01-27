using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    // this is our own exception. we override Message property i.e e.Message that we do in Exception e, to make our own, it is by default readonly so we use get.
    class DivideByEvenNumberException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to divide by even number";
            }
        }
    }
    internal class ThrowApplicationException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter x: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter y: ");
                int y = int.Parse(Console.ReadLine());

                double z = x / y;
                Console.WriteLine(z);

                if (y % 2 != 0)
                {
                    //if y is odd throw application / our own exception
                    throw new ApplicationException("Dont use odd number for y");
                }

                if(y % 2 == 0)
                {
                    // if y is even throw our custom exception
                    throw new DivideByEvenNumberException();
                }

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception xe)
            {
                Console.WriteLine(xe.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }

            Console.ReadLine();
        }
    }
}


