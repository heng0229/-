using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("請輸入中華民國年分:");
            string input = Console.ReadLine();
            a = int.Parse(input);
            b = a + 1911;
            if (DateTime.IsLeapYear(b))
            {
                Console.WriteLine($"民國{a}年 是閏年");
            }
            else
            {
                Console.WriteLine($"民國{a}年 不是閏年");
            }
            Console.ReadLine();
        }
    }
}
