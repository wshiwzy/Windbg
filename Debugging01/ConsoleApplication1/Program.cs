using System;
using System.Text;

namespace ConsoleApplication1
{
    class TypeSample
    {
        TypeSample(int x,int y,int z)
        {
           
        }
        private struct Coordinates
        {
            public int x;
            public int y;
            public int z;
        }

        private Coordinates coordinates;

        public void AddCoordinates()
        {
            int hashCode = GetHashCode();
            lock (this)
            {
                Coordinates temp;
                temp.x = coordinates.x + 100;
                temp.y = coordinates.y + 50;
                temp.z = coordinates.z + 100;

                Console.WriteLine("x={0},y={1},z={2}", temp.x, temp.y, temp.z);
            }
        }
        static void Main(string[] args)
        {
            TypeSample sample = new TypeSample(10, 5, 10);
            sample.AddCoordinates();
        }
    }
}
