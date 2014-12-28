using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Sample
{
    class Name
    {
        private string first;

        private string last;
        public string First { get { return first; } }
        public string Last { get { return last; } }

        public Name(string f,string l)
        {
            first = f;
            last = l;
        }

    }

    class SimpleAlloc
    {
        static void Main(string[] args)
        {
            Name name = null;
            Console.WriteLine("Press any key to allocate memory");
            Console.ReadKey();

            name = new Name("Mario", "Hewardt");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
