using System;

namespace MethodOverriding
{
    public class Parent
    {
        // overloading ko lagi
        public void Test()
        {
            Console.WriteLine("This is of parent test");
        }

        // overriding ko lagi
        public virtual void Ns200()
        {
            Console.WriteLine("Non modified Ns200");
        }

        // method hiding = vaneko override nagari virtual halera banauna ni parena sidae method hide/shadow gada new keyword halne
        // new key word halena vane parent ra child ko same hunxa function name so warning dinxa ani child ko matra acces hunxa
        public void FZV2()
        {
            Console.WriteLine("Non modified FZV2");
        }
    }

    public class Program : Parent
    {
        // overload garne ava test lae
        public void Test(string kho)
        { 
            Console.WriteLine(kho + " Bujes ni motey"); 
        }

        // override garne ava ns lae
        public override void Ns200()
        {
            Console.WriteLine("MODIFIED NS 200 GRAPHICS, TYRE APOLLO");
            Console.WriteLine("Overload gares haina modify vaneko khatey, ava purano NS200 paudainas");
        }

        // method hiding
        public new void FZV2() 
        {
            Console.WriteLine("Modify garesKE GPS RA MUDguard");
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Test();
            obj.Test("Yei ho overloading vaneko");

            // overload garexi paila ko ns paudainas bhai taile
            obj.Ns200();


            // method hiding garexi new keyword
            Parent parent = new Parent();
            parent.FZV2();

            obj.FZV2();

            parent.Ns200();

            Console.ReadLine();
        }
    }
}
