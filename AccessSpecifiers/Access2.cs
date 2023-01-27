using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    public class Access2 : Home
    {
        private float sellCommission;

        public Access2(float sellCommission) : base("Anish House", true, 23500000.45, 234)
        {
            this.sellCommission = sellCommission;
        }
        

        static void Main(string[] args)
        {
            Access2 anishHouse = new Access2(45000f);

            anishHouse.DisplayDetails();
            Console.WriteLine(anishHouse.party); // public through inherit possible

            Console.WriteLine(anishHouse.willbe); // protected through inherit possible

            Console.WriteLine(anishHouse.piss); // protected internal through inherit possible

            Console.WriteLine(anishHouse.inter); // internal through inherit possible



            // -----------------
            // Now lets test by creating object of house without inherit
            Home check = new Home("Chhabal, Kirtipur-2", false, 14500000.748, 4968);

            Console.WriteLine(check.party); // by creating instance - public accessible

            Console.WriteLine(check.piss); // protected internal accesible as one of them is true i.e internal by making instance.

            Console.WriteLine(check.inter); // interal is accssible using instance 

            Console.ReadLine();
        }
    }
}
