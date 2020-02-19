using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("輸入一個整數數字：");
            string input = Console.ReadLine();
            i = int.Parse(input);
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i}　是偶數");
            }
            else
            {
                Console.WriteLine($"{i}　是奇數");
            }
            Console.ReadLine();
        }
    }
}
