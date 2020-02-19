using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var list2 = new List<int> { 1, 3, 4, 7, 8, 9 };
            var Except1 = list1.Except(list2);
            Console.WriteLine("A差集B的結果為:");
            foreach (var item in Except1)
            {
                Console.WriteLine(item);
            }
            var Except2 = list2.Except(list1);
            Console.WriteLine("B差集A的結果為:");
            foreach (var item in Except2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
