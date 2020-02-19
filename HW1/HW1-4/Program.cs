using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i, j;
            Console.Write("請輸入一個整數:");
            string input = Console.ReadLine();
            a = int.Parse(input);
            for (i = a; i >0;i--)
            {
                for (j = 0;j < a-i+1 ; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
