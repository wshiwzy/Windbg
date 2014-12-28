using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07Sample
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

    class Roots
    {
        public static Name CompleteName = new Name("frist", "last");
        private Thread thread;
        private bool shouldExit;

        static void Main(string[] args)
        {
            Roots r = new Roots();
            r.Run();


        }

        public void Run()
        {
            shouldExit = false;
            Name n1 = CompleteName;
            thread = new Thread(this.worker);
            thread.Start(n1);

            Thread.Sleep(1000);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            shouldExit = true;
        }

        public void worker(object o)
        {
            Name n1 = (Name)(o);
            Console.WriteLine("Thread started {0},{1}",
                n1.First
                , n1.Last);
            while(true)
            {
                Thread.Sleep(500);
                if (shouldExit)
                    break;
            }
        }
    }
}