using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add(1, 1));
            Console.WriteLine(add(1, 2,3));
            Console.WriteLine(add(1.5, 3.2));
            Console.WriteLine(add(9.8, 7));
            Console.WriteLine(add("A", "B"));
            Console.WriteLine(add("XYZ", 100));
            Console.ReadLine();
        }
        static int add(int x, int y)
        { return x + y; }
        static int add(int x, int y, int z)
        { return x + y + z; }
        static double add(double x, double y)
        { return x + y; }
        static string add(string x, string y)
        { return x + y; }
        static string add(string x, int y)
        { return x + "整數" + y.ToString(); }
    }
}
