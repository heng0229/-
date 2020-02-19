using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplayWithMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("請輸入一個數:");
            string input = Console.ReadLine();
            value = int.Parse(input);
            string result = GetResult(value);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static string GetResult(int value)
        {
            switch(value)
            {
                case 1:
                    return "數字是 1";
                case 2:
                    return "數字是 2";
                default:
                    return "數字不再條件內";
            }
        }
    }
}
