using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Sample
{
    class Name
    {
        private string first;

        private string last;
        public string First { get { return first; } }
        public string Last { get { return last; } }

        public Name(string f, string l)
        {
            first = f;
            last = l;
        }

    }

    class Gen
    {
        static void Main(string[] args)
        {
            Name n1 = new Name("mario", "hewardt");

            Name n2 = new Name("Gemma", "hewardt");

            Console.WriteLine("Allocated objects");

            Console.WriteLine("Press any key wo invoke gc");

            Console.ReadKey();

            n1 = null;

            GC.Collect();

            Console.WriteLine("Press any key wo invoke gc");
            Console.ReadKey();

            GC.Collect();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

           
        }
    }
}