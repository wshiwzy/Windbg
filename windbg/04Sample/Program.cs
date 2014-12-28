using System;
using System.Text;

namespace _04Sample
{
    public class ObjType
    {
        public struct Coordinates
        {
            public int xCord;
            public int yCord;
            public int zCord;
            public Coordinates(int x,int y ,int z)
            {
                xCord = x;
                yCord = y;
                zCord = z;
            }
        }

        private Coordinates coordinates;

        int[] intArray = new int[] { 1, 2, 3, 4, 5 };
        string[] strArray = new string[] { "welcome", "to", "beijing", "!" };

        static void Main(string[] args)
        {
            Coordinates point = new Coordinates(100, 100, 100);
            Console.WriteLine("press any key to continue (addcoordinate)");
            Console.ReadKey();
            ObjType ob = new ObjType();
            ob.AddCoordinates(point);

            Console.WriteLine("press any key to continue (array)");
            Console.ReadKey();
            ob.PrintArrays();

            Console.WriteLine("press any key to continue (Generics)");
            Console.ReadKey();
            Comparer<int> c = new Comparer<int>();
            Console.WriteLine("Greater {0}", c.GreaterThan(6, 10));

            Console.WriteLine("Press any key to continue (Exception)");
            Console.ReadKey();
            ob.ThrowException(null);


        }
        public void AddCoordinates(Coordinates co)
        {
            coordinates.xCord += co.xCord;
            coordinates.yCord += co.yCord;
            coordinates.zCord += co.zCord;
            Console.WriteLine("x:{0},y:{1},z:{2}", coordinates.xCord, coordinates.yCord, coordinates.zCord);
        }

        public void PrintArrays()
        {
            foreach (var i in intArray)
            {
                Console.WriteLine("int:{0}", i);
            }
            foreach (string s in strArray)
            {
                Console.WriteLine("str:{0}", s);
            }
        }

        public void ThrowException(ObjType obj)
        {
            if(obj==null)
            {
                throw new System.ArgumentException("obj cannot be null");
            }
        }

        public class Comparer<T> where T:IComparable
        {
            public T GreaterThan(T d,T d2)
            {
                int ret = d.CompareTo(d2);
                if (ret > 0)
                    return d;
                else
                    return d2;
            }

            public T LessThan(T d,T d2)
            {
                int ret = d.CompareTo(d2);
                if (ret < 0)
                    return d;
                else
                    return d2;
            }
        }
    }
}
