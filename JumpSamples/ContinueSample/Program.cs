using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int condition = 15;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine($"i={i}");
                for (j = 11; j < 20; j++)
                {
                    if (j == condition)
                    {
                        continue;
                    }
                    //Console.WriteLine($"j={j}");
                    Console.WriteLine("(" + $"{i},{j}" + ")");
                }
            }
            Console.ReadLine();
        }
    }
}
