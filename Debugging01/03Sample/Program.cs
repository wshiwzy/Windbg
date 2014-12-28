using System;

namespace _03Sample
{
    public class Breakpoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key (1st instance function)");
            Console.ReadKey();
            Breakpoint bp = new Breakpoint();
            bp.AddAndPrint(10, 5);


            Console.WriteLine("Press any key (2nd instance function)");
            Console.ReadKey();
            bp = new Breakpoint();
            bp.AddAndPrint(100, 50);
        }

        public void AddAndPrint(int p1, int p2)
        {
            int res = p1 + p2;
            Console.WriteLine(string.Format("Adding {0}+{1}={2}", p1.ToString(), p2.ToString(), res.ToString()));
        }
    }
}
